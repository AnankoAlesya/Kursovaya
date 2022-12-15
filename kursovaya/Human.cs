using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Human
    {
        private string name;
        private string surname;
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public String Name
        {
            get { return name; }
        }
        public String Surname
        {
            get { return surname; }
        }

        public override string ToString()
        {
            return String.Format("Имя: {0}, Фамилия: {1}", name, surname);
        }
    }
}
