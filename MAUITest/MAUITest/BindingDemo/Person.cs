using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITest.BindingDemo
{
   public class Person
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public int Age { get; internal set; }
        public bool IsMarried { get; internal set; }
        public int Weight { get; internal set; }
        public TimeSpan LunchTime { get; internal set; }
        public DateTime BirthDate { get; internal set; }
    }
}
