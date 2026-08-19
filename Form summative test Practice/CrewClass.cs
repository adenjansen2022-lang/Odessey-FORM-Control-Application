using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_summative_test_Practice
{
    abstract class CrewClass
    {
        int _id;
        string _name;
        string _role;
        public int id
        {
            get { return _id; }
            set 
            { 
                if(value <0)
                {
                    throw new ArgumentException("ID cannot be negative");
                }
                _id = value; 
            }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string role
        {
            get { return _role; }
            set { _role = value; }
        }

        public CrewClass(int id, string name, string role) 
        {
            this.name = name;
            this.id = id;
            this.role = role;
        }
        public abstract string PerformDuty();

        public override string ToString()
        {
            return $"{id}\t {name}\t {role}";
        }

    }
}
