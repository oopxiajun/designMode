using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern_过滤器模式.Example1
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (var person in persons)
            {
                if (person.gender.ToUpper().Equals("FEMALE"))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}
