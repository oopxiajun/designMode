using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern_过滤器模式.Example1
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.maritalStatus.ToUpper().Equals("SINGLE"))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}
