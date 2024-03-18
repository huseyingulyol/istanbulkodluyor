using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Encapsulation
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }

        private int _age = 0;
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth {
            get
            {
                _age = (int)((DateTime.Now - _dateOfBirth).TotalDays / 365);
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        public string GenderValue()
        {
            return Gender ? "Erkek" : "Kadın";
        }
        public int Age()
        {
            return _age;
        }

    }
}
