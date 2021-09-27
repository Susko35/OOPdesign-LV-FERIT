using System;
using System.Threading;

namespace LV3Doop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LV3 DOOP\n\n");

            Dataset newDS = new Dataset("1.txt");
            Console.WriteLine(newDS.DatasetOutput());

            MatrixGenerator matrix = MatrixGenerator.GetInstance();
            matrix.MatrixOutput();

            Notification noticeAlert = new Notification("Autor asdd", "Naslov notifikacija obavijest", "Tijelo obavijesti za prikazat ALERT", DateTime.Now, Category.ALERT, ConsoleColor.DarkYellow);
            Notification noticeError = new Notification("Autor wdwada", "Naslov notifikacija obavijest", "Tijelo obavijesti za prikazat ERROR", DateTime.Now, Category.ERROR, ConsoleColor.DarkRed);
            Notification noticeInfo = new Notification("Autor rfdfa", "Naslov notifikacija obavijest", "Tijelo obavijesti za prikazat INFO", DateTime.Now, Category.INFO, ConsoleColor.Green);
            NotificationManager noticeManager = new NotificationManager();
            noticeManager.Display(noticeAlert);
            noticeManager.Display(noticeError);
            noticeManager.Display(noticeInfo);

            NotificationBuilder builder = new NotificationBuilder();
            Director director = new Director();
            director.Construct(builder, "Autor");
            Notification noticeBuilt = builder.Build();
            noticeManager.Display(noticeBuilt);
        }
    }
}
