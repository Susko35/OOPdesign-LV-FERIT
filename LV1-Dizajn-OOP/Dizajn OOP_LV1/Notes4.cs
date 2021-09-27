using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak4
{
    class Notes4
    {
        private string author;
        private string noteContent;
        private int importanceLevel;
        public string Author { get => author; set => author = value; }
        public string NoteContent { get => noteContent; set => noteContent = value; }
        public int ImportanceLevel { get => importanceLevel; set => importanceLevel = value; }

        public Notes4(string author, string noteContent, int importanceLevel)
        {
            this.author = author;
            this.noteContent = noteContent;
            this.importanceLevel = importanceLevel;
        }

        public Notes4()
        {
            this.author = "";
            this.noteContent = "";
            this.importanceLevel = 0;
        }

        public Notes4(string author)
        {
            this.author = author;
            this.noteContent = "";
            this.importanceLevel = 0;
        }
    }
}
