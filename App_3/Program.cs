using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Key;
            Console.WriteLine($"Введiть ключ доступу (можете вiдмовитись, натиснувши символ 'N') :");
            Key = Console.ReadLine();
            Console.WriteLine($"Ваш ключ: '{Key}'\n");

            switch (Key)
            {

                case "pro":
                    {
                        Console.WriteLine($"Вас вiтає версiя Pro\n");
                        ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                        proDocumentWorker.OpenDocument();
                        proDocumentWorker.EditDocument();
                        proDocumentWorker.SaveDocument();

                        break;
                    }


                case "exp":
                    {
                        Console.WriteLine($"Вас вiтає версiя Expert\n");
                        ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                        expertDocumentWorker.OpenDocument();
                        expertDocumentWorker.EditDocument();
                        expertDocumentWorker.SaveDocument();

                        break;
                    }


                case "N":
                    {
                        Console.WriteLine($"Вас вiтає безкоштовна версія\n");
                        DocumentWorker docworker = new DocumentWorker();
                        docworker.OpenDocument();
                        docworker.EditDocument();
                        docworker.SaveDocument();

                        break;
                    }


                    default:

                    Console.WriteLine("Невiрна дiя. Такого коду немає.");

                        break;

            }
            


        }

    }


    class DocumentWorker
    {

        public virtual void OpenDocument()
        {

            Console.WriteLine("Документ вiдкритий");

        }

        public virtual void EditDocument()
        {

            Console.WriteLine("Правка документа доступна у версiї - Pro");

        }

        public virtual void SaveDocument()
        {

            Console.WriteLine("Збереження документа доступне у версiї - Pro");

        }

    }


    class ProDocumentWorker : DocumentWorker
    {

        public override void EditDocument()
        {

            Console.WriteLine("Документ вiдредаговано");

        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версiї - Expert");
        }

    }


    class ExpertDocumentWorker : ProDocumentWorker
    {

        public override void SaveDocument()
        {

            Console.WriteLine("Документ збережений в новому форматi");

        }

    }





}
