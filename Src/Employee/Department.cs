using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.src.Employee
{
    class Department
    {

        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public Department()
        {
        }

        public override string ToString()
        {
            return base.ToString() + "(" + Name +")";
        }
    }
}
