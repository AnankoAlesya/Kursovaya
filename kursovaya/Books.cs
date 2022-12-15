using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Books
    {
        private int key;
        private string name;
        private string author;
        private DateTime date_of_publishing;
        private bool is_available;
        private int number_of_copies;
        //общее колво і колво на руках
        
        public Books(int key,string name, string author, DateTime date_of_publishing, int number_of_copies)
        {
            this.key = key;
            this.name = name;
            this.author = author;
            this.date_of_publishing = date_of_publishing;
            this.number_of_copies = number_of_copies;
            this.is_available = true;
        }
        public bool Is_avaible
        {
            get { return is_available; }
            set { is_available = value; }
        }
        public int Number_of_copies
        {
            set { number_of_copies = value; }
        }
        //if someone gets book number_of_copies -1 
        //if number_of_copies == 0 is_avaible = false

        public override string ToString()
        {
            return string.Format("Номер:{0} Название:{1} Автор:{2} Дата публикации:{3}",key, name, author, date_of_publishing);
        }
    }
}
