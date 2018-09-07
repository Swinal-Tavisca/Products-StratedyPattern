using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class SingletonInstance
    {
        private static SingletonInstance instance;
        string path= @"C:\log.txt";
        private SingletonInstance()
        {

        }
        public static SingletonInstance CreateInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonInstance();
                }
                return instance;
            }
            
        }
        public void log(string msg)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(msg);

            }
        }
        
       
    }
}
