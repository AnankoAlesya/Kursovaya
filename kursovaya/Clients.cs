using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    public enum Roles
    {
        Students,
        Teachers
    }
    class Clients:Human
    {
        private Roles role; 
        private Cards carta;

        public Clients(string name, string surname, Cards carta, Roles role) : base(name, surname)
        {
            this.carta = carta;
            this.role = role;
        }

        public Cards Carta
        {
            get { return carta; }
            set { carta = value; }
        }


        public override string ToString()
        {
            return String.Format("Имя: {0} Фамилия: {1} Роль: {2}  Карта: {3}", this.Name, this.Surname, this.role, this.Carta);
        }
    }
}

