﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DiceRoll
//{
//    class Logger : ILogger
//    {
//        private string type;
//        private string filePath;

//        public Logger(string type, string filePath)
//        {
//            this.type = type;
//            this.filePath = filePath;
//        }

//        public void Log(string message)
//        {
//            if (this.type.Equals("Console"))
//                Console.WriteLine(message);
//            else if (this.type.Equals("file"))
//            {
//                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
//                {
//                    writer.WriteLine(message);
//                }
//            }
//            else
//                throw new ArgumentException("Unknown type");
//        }
//    }
//}
