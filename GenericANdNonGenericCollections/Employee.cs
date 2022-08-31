using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericANdNonGenericCollections
{
    class Employee
    {

        //constructor
        public Employee(string role, string name, int age, float rate)
        {
            Role = role;
            Name = name;
            Age = age;
            Rate = rate;
        }

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
    }
}
