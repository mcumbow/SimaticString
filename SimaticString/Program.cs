using System;

namespace SimaticString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimaticString ss = new SimaticString(20);
            ss.GetBytes();
            ss.Set(ss.GetBytes());
            //ss.Set("Andy");
            //Console.WriteLine(ss.ToString());
            //Console.WriteLine(ss.Length);
			//try
			//{
                //ss.Set(null as string);
            //}
            //catch (Exception ex)
			//{
               // Console.WriteLine(ex.ToString());
			//}
            
            //Console.WriteLine(ss.ToString());
            //Console.WriteLine(ss.Length);

        }
    }
}