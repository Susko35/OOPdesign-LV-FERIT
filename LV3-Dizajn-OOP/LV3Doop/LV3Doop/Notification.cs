using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Doop
{
    public enum Category { ERROR, ALERT, INFO }
    public class Notification
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public Notification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }
        public Notification()
        {
            this.Author = "0000";
            this.Title = "NoTitle";
            this.Text = "Empty";
            this.Timestamp = DateTime.MinValue;
            this.Level = Category.ALERT;
            this.Color = ConsoleColor.Blue;
        }
    }

    class NotificationManager
    {
        public void Display(Notification notification)
        {
            Console.ForegroundColor = notification.Color;
            Console.Write(notification.Author + ": ");
            Console.WriteLine(notification.Title);
            Console.WriteLine(notification.Timestamp.ToString());
            Console.WriteLine(notification.Text);
            Console.WriteLine(notification.Level);
            Console.ResetColor();
        }

    }

    public interface IBuilder
    {
        Notification Build();
        IBuilder SetAuthor(String author);
        IBuilder SetTitle(String title);
        IBuilder SetTime(DateTime time);
        IBuilder SetLevel(Category level);
        IBuilder SetColor(ConsoleColor color);
        IBuilder SetText(String text);
    }

    public class NotificationBuilder : IBuilder
    {
        public String Author;
        public String Title;
        public String Text;
        public DateTime Timestamp;
        public Category Level;
        public ConsoleColor Color;

        public NotificationBuilder() { }
        
        public Notification Build()
        {
            return new Notification(Author, Title,Text,Timestamp,Level,Color);
        }
        public IBuilder SetAuthor(String author)
        {
            this.Author = author; return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.Title = title; return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.Timestamp = time; return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.Level = level; return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.Color = color; return this;
        }
        public IBuilder SetText(String text)
        {
            this.Text = text; return this;
        }
    }

    public class Director
    {
        public void Construct(IBuilder builder,string author)
        {
            builder.SetAuthor(author).SetTitle("Naslov").SetText("Tijelo obavijesti")
                .SetLevel(Category.ERROR).SetColor(ConsoleColor.Red).SetTime(DateTime.Now);
        }
    }

}
