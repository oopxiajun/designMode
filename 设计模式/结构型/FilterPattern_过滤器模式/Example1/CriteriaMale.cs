using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern_过滤器模式.Example1
{
    public class CriteriaMale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (var person in persons)
            { 
                if (person.gender.ToUpper().Equals("MALE"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
