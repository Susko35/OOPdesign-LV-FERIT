using LV5_Dizajn_OOP.Most;
using LV5_Dizajn_OOP.Proxy;
using System;

namespace LV5_Dizajn_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "proxy.csv";

            Console.WriteLine("Hello World!");

            Dataset dataset = new Dataset(filepath);
            
            ProtectionProxyDataset protProxy = new ProtectionProxyDataset(User.GenerateUser("User122"));
            VirtualProxyDataset virtProxy = new VirtualProxyDataset(filepath);

            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(dataset);
            printer.Print(protProxy);
            printer.Print(virtProxy);
            printer.Print(protProxy);
            printer.Print(protProxy);

            Console.WriteLine("\n\n");

            ReminderNote note1 = new ReminderNote("Poruka 1, prikaz LighTheme", new LightTheme());
            ReminderNote note2 = new ReminderNote("Poruka 2, prikaz PersonalTheme", new PersonalTheme());
            note1.Show();
            Console.WriteLine("\n\n");
            note2.Show();




        }
    }
}
