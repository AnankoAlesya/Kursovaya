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
        public static bool Is_Name_or_Surname_Valide(string name, string surname)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) )return false;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Имя: {0}, Фамилия: {1}", name, surname);
        }
    }
}
