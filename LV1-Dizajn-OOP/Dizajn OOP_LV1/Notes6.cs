using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak5i6
{
    class Notes6 : Notes5
    {
        private DateTime timeStamp;

        public Notes6(string author, string noteContent, int importanceLevel, DateTime timeStamp)
        {
            this.Author = author;
            this.NoteContent = noteContent;
            this.ImportanceLevel = importanceLevel;
            this.TimeStamp = timeStamp;
        }
        public Notes6()
        {
            this.Author = "";
            this.NoteContent = "";
            this.ImportanceLevel = 0;
            this.TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }

        public override string ToString()
        {
            return base.ToString()+" Vrijeme izrade: "+TimeStamp;
        }
    }
}
