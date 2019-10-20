using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern_过滤器模式.Example1
{
    public class Person
    {
        public String name { get; set; }
        public String gender { get; set; }
        public String maritalStatus { get; set; }

        public Person(String name, String gender, String maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }
    }
}
