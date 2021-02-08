using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry = false;

            string sourcePath = @"C:\Users\MRX\Desktop\C# Profissional\JoalheriaPrime\Arquivos\Saves\save1.txt";
            string targPath = @"C:\Users\MRX\Desktop\C# Profissional\JoalheriaPrime\Arquivos\Saves\file2.txt";
            do
            {
                try
                {
                    //Copiando arquivo sourcePath para targPath
                    //FileInfo fileinfo = new FileInfo(sourcePath);
                    //fileinfo.CopyTo(targPath);
                    string[] lines = File.ReadAllLines(targPath);
                    
                    foreach (string line in lines)
                        Console.WriteLine(line);                

                    if (retry)
                        retry = false;
                }
                catch (IOException ex)
                {
                    if(!(ex.Message.Contains("já existe")))
                    retry = true;

                    Console.WriteLine("Erro: ");
                    Console.WriteLine(ex.Message);
                }
            } while (retry);
            Console.Read();
        }
    }
}
