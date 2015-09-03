using DataParser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Option;
using Utilities.Strings;

namespace CsvParser
{
    public class CsvFileReaderEnumerator<T> : IEnumerator<T> where T : new()
    {
        private const char DEFAULT_DELIMITER = ',';

        private readonly char _delimiter;
        private readonly bool _isStrict;

        private readonly StreamReader _reader;
        private readonly ObjectMapper<T> _mapper;

        private readonly string[] _headers;

        private string _currentLine;

        public CsvFileReaderEnumerator(StreamReader reader, ObjectMapper<T> mapper, bool strictMode = false, char delimiter = DEFAULT_DELIMITER)
        {
            _reader = reader;
            _mapper = mapper;

            _isStrict = strictMode;
            _delimiter = delimiter;

            if (MoveNext())
            {
                _headers = _currentLine.Split(_delimiter);
                _currentLine = null;
            }
        }

        public T Current { get { return CreateObjectFromLine(_currentLine.Split(_delimiter)); } }

        private T CreateObjectFromLine(string[] line)
        {
            T item = new T();

            for (int i = 0; i < line.Length; i++)
            {
                var header = _headers[i];
                var value = line[i].Trim('"');

                if (_mapper.Mappings.ContainsKey(header))
                {
                    ExtractValue(item, header, value);
                }
            }

            return item;
        }

        private void ExtractValue(T item, string header, string value)
        {
            var mapping = _mapper.Mappings[header];
            object parsedValue;

            try
            {
                parsedValue = mapping.DataConverter(value);
            }
            catch (Exception e) { throw new MappingConversionException($"Could not convert [{header}]: {value}", e); }

            mapping.Field.SetValue(item, parsedValue);
        }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            _reader.Dispose();
        }

        public bool MoveNext()
        {
            return (_currentLine = _reader.ReadLine()).IsPresent();
        }

        public void Reset()
        {
            _reader.BaseStream.Seek(0, SeekOrigin.Begin);
            MoveNext();

            _currentLine = null;
        }
    }
}
