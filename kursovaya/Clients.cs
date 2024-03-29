﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    public enum Roles
    {
        STUDENT,
        TEACHER
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
        public static bool Dolg(Roles role, DateTime returning_book, DateTime taking_book)
        {
            TimeSpan interval = returning_book.Subtract(taking_book);
            if (role == Roles.STUDENT && interval.Days > 30) return false;
            else if (role == Roles.TEACHER && interval.Days > 365) return false;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Имя: {0} Фамилия: {1} Роль: {2}  Карта: {3}", this.Name, this.Surname, this.role, this.Carta);
        }
    }
}

