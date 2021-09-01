using System;
using System.Collections.Generic;

namespace APITest.Controllers
{
    public class ValuesHolder
    {
        //private List<string> _values ;

        //public ValuesHolder()
        //{
        //    _values??= new List<string>();
        //}

        //public void Add(string input)
        //{
        //    _values.Add(input);
        //}

        //public List<string> Get()
        //{
        //    return _values;
        //}

        //*******************

        public List<string> Values { get; set; } = new List<string>();


    }
}