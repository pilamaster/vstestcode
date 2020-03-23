using System;
using System.IO;
using System.Threading;
using System.Text;

namespace mpu_v1
{
    class MainClass
    {
        //private string writePath2 = "file2.txt";
        public static void Main(string[] args)
        {
            string writePath1 = "file1.txt";
            //string writePath2 = "file2.txt";
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();
            try
            {
                using (StreamWriter sw1 = new StreamWriter(writePath1, false, Encoding.Default))
                {
                    sw1.WriteLine("thread 1");
                }
                Console.WriteLine("first file is ready");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*for (int i = 1; i < 9; i++)
            {
                //Console.WriteLine("Main thread:");
                //Console.WriteLine(i * i);
                //Thread.Sleep(300);
            }*/

            //Console.ReadLine();
        }

        public static void Count()
        {
            string writePath2 = "file2.txt";
            try
            {
                using (StreamWriter sw2 = new StreamWriter(writePath2, false, Encoding.Default))
                {
                    sw2.WriteLine("thread 2");
                }
                Console.WriteLine("second file is ready");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*for (int i = 1; i < 9; i++)
            {
                //Console.WriteLine("Second thread:");
                //Console.WriteLine(i * i);
                //Thread.Sleep(400);
            }*/
        }
    }
}
