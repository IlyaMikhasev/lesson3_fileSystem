using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;


namespace lesson3_fileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;

            /*if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                path = Environment.CurrentDirectory;
            }*/
            /* try
             {
                 path = args[0];
             }
             catch (Exception e0)
             {
                 Console.WriteLine(e0.Message);
                 path = Environment.CurrentDirectory;
             }
                 DirectoryInfo myDirect = new DirectoryInfo(path);
                     foreach (var item in myDirect.EnumerateDirectories())
                     {
                         Console.WriteLine($"Каталог {item}");
                     }
             foreach (var item in myDirect.EnumerateFiles())
             {
                 Console.WriteLine($"file {item} имеет размер {item.Length} байт, был изменен {item.LastAccessTime}");
                 var lastModificalty = myDirect.LastWriteTime;
                 TimeSpan delta = item.LastAccessTime - lastModificalty;

                 int year = int.Parse(lastModificalty.ToString("yyyy"));
             }*/




            /* for (int i = (int)'0'; i <= (int)'9'; i++)
             {
                 Console.WriteLine(((char)i).ToString()+" имеет код " +i);
             }*/





            /* var path = Environment.GetFolderPath
                 (Environment.SpecialFolder.MyDocuments);//возвращает путь к папке мои документы независимо от пользователя
             var path1 = Environment.CurrentDirectory;
             DirectoryInfo myDirect = new DirectoryInfo(path1);
             foreach (var item in myDirect.EnumerateDirectories())
             {
                 Console.WriteLine($"Каталог {item}");
             }
             foreach (var item in myDirect.EnumerateFiles())
             {
                 Console.WriteLine($"file {item} имеет размер {item.Length} байт, был изменен {item.LastAccessTime}");
             }*/

            //регулярные выражения
            //var reg = new Regex("\\d+\\s*(\\+|\\-|\\*|\\/)");
            //@\d +\s * (\+|\-|\*|\/)
            string input="23 * 45 =";
            
            var regexleft = new Regex(@"\d+\s*(\+|\-|\*|\/)");
            var regexrigth = new Regex(@"(\+|\-|\*\/)\s*\d+");
            var regNum = new Regex(@"\d+");
            var regexOperator = new Regex(@"(\+|\-|\*\/)");
            MatchCollection matchesleft = regexleft.Matches(input);//проверяет инпут на совпадения
            MatchCollection matchesrigth = regexrigth.Matches(input);//проверяет инпут на совпадения

            foreach (var item in matchesleft)
            {
                Console.WriteLine("Левый операнд и операция "+item.ToString());
                MatchCollection numLeft = regNum.Matches(item.ToString());
                Console.WriteLine("левый операннд "+numLeft[0]);
            }
            foreach (var item in matchesrigth)
            {
                Console.WriteLine("правый операнд и операция " + item.ToString());
                MatchCollection numrigth = regNum.Matches(item.ToString());
                Console.WriteLine("правый операннд " + numrigth[0]);
            }
            Console.WriteLine();
        }
    }
}
