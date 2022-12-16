using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace kursovaya
{
    class Cards
    {
        private string number;
        private List<Recordings> recording;
        public Cards(string number,List<Recordings> recording)
        {
            this.number = number;
            this.recording = recording;
        }
        public static bool Is_Number_Valide(string number)
        {
            string regex = @"(T|S){1}[0-9]{3}";
            if (!Regex.IsMatch(number, regex) ) return false;
            return true;
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
