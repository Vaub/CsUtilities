using DataParser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CsvParser
{
    public class CsvFileReader<T> : IDataReader<T> where T : new()
    {
        public string FileName { get; }
        private readonly ObjectMapper<T> _mapper;

        public CsvFileReader(string fileName, ObjectMapper<T> mapper)
        {
            FileName = fileName;
            _mapper = mapper;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var stream = File.OpenRead(FileName);
            return new CsvFileReaderEnumerator<T>(new StreamReader(stream), _mapper);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
