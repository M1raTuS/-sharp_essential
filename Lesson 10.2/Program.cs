using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = "SOFTWARE\\WOW6432Node\\Microsoft\\.NETFramework\\v2.0.50727\\NGenService\\Roots";
            RegistryKey[] key = {Registry.ClassesRoot,Registry.CurrentConfig,
                                   Registry.LocalMachine, Registry.CurrentUser,Registry.Users};

            foreach (var rk in Registry.LocalMachine.GetSubKeyNames())
            {
                var q = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(t,true);
                Console.WriteLine(rk);
                if (rk.Contains("SOFTWARE"))
                {
                    Console.WriteLine(new string('-', 50));
                    foreach (var qw in q.GetSubKeyNames())
                    {
                        var s = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(t + "\\" + qw,true);
                        try
                        {
                            if (s.ToString().Contains("Management Studio"))
                            {
                                Console.WriteLine(s.ToString());
                                Console.WriteLine(q);
                                Console.WriteLine(qw);

                                q.DeleteSubKey(qw,true);
                                break;
                            }
                           
                            string asd = "5C5F996FD13E5C2418C586214B9E6958";
                           var ss = s.GetValue(asd, "no");
                            if (!(ss.Equals("no")))
                            {
                                Console.WriteLine(ss);
                                //Console.WriteLine(s.ToString());
                                //s.DeleteValue(asd, true);
                                //Console.WriteLine(ss);

                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            break;
                            
                        }
                        
                        if (false)
                        {
                            
                        }
                        
                    }
                    Console.WriteLine(new string('-', 50));
                }
            }
            
            Console.ReadKey();
        }
       // Microsoft SQL Server Management Studio 18

    }
}
