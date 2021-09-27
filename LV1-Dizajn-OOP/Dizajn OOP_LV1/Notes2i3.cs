using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak2i3
{
    class Notes2i3
    {
        private String author;
        private String noteContent;
        private int importanceLevel;

        public Notes2i3(string author, string noteContent, int importanceLevel)
        {
            this.author = author;
            this.noteContent = noteContent;
            this.importanceLevel = importanceLevel;
        }

        public Notes2i3()
        {
            this.author = "";
            this.noteContent = "";
            this.importanceLevel = 0;
        }

        public Notes2i3(string author)
        {
            this.author = author;
            this.noteContent = "";
            this.importanceLevel = 0;
        }

        public void setNoteContent(string noteContent) { this.noteContent = noteContent; }
        public void setImportanceLevel(int importanceLevel) { this.importanceLevel = importanceLevel; }

        public string getAuthor() { return this.author; }
        public string getNoteContent() { return this.noteContent; }
        public int getImportanceLevel() { return this.importanceLevel; }



    }
}
