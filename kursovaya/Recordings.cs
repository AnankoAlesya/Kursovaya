using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Recordings
    {

        private DateTime taking_book;
        private DateTime returning_book;
        private Books book;// students are returning books after 1 month, teachers - after 1 year;
                           //вывод соответствующего сообщения, если книга не сдана вовремя
                           //проверка на корректный ввод дат, типа дата возврата >  даты взятия,
                           //если  дата возврата < даты взятия - поменять их местами
        public static void Is_Data_Valide(DateTime taking_book, DateTime returning_book)
        {
            if (returning_book < taking_book)
            {
                DateTime time = taking_book;
                taking_book = returning_book;
                returning_book = time;
            }
        }
        
        public Recordings(DateTime taking_book, DateTime returning_book, Books book)
        {
            this.taking_book = taking_book;
            this.returning_book = returning_book;
            this.book = book;
        }

        public override string ToString()
        {
            return string.Format("Дата взятия книги: {0}  Дата возврата книги: {1} Книга: {2} ", taking_book.ToShortDateString(), returning_book.ToShortDateString(), book );
        }
    }
}
