using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    class Cards
    {
        private string number;//example  if it's a teacher: number = T123, if it's student: number = S456;(с помощью регулярных выражений)
        // проверка номера шаблону
        private List<Recordings> recording;
        public Cards(string number,List<Recordings> recording)
        {
            this.number = number;
            this.recording = recording;
        }

        public List<Recordings> Recordings
        {
            get { return recording; }
            set { recording = value; }
        }

        public override string ToString()
        {
            return string.Format("Запись: {0}", recording);
        }
    }
}
