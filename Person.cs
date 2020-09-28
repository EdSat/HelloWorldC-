using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person(string name1, int age1)
        {
            name = name1;
            age = age1;
        }
    }
}
