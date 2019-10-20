using System;
using System.Collections.Generic;
using System.Text;

namespace FilterPattern_过滤器模式.Example1
{
    public interface Criteria
    {
         List<Person> meetCriteria(List<Person> persons);
    }
}
