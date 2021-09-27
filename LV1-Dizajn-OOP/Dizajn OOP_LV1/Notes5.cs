using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak5i6
{
    class Notes5
    {
        private string author;
        private string noteContent;
        private int importanceLevel;
        public string Author { get => author; set => author = value; }
        public string NoteContent { get => noteContent; set => noteContent = value; }
        public int ImportanceLevel { get => importanceLevel; set => importanceLevel = value; }

        public Notes5(string author, string noteContent, int importanceLevel)
        {
            this.author = author;
            this.noteContent = noteContent;
            this.importanceLevel = importanceLevel;
        }

        public Notes5()
        {
            this.author = "";
            this.noteContent = "";
            this.importanceLevel = 0;
        }

        public Notes5(string author)
        {
            this.author = author;
            this.noteContent = "";
            this.importanceLevel = 0;
        }
        public override string ToString()
        {
            return "Autor: "+this.author+" Zabiljeska: "+this.noteContent+" Razina vaznosti: "+this.importanceLevel;
        }

    }
}
