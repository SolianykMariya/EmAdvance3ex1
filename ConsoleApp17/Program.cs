using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class IDandNAME
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class CRUD
    {
        private static List<IDandNAME> items = new List<IDandNAME>();
        private static int nextID = 1;

        public static void Create(string name)
        {
            var IDandNAME = new IDandNAME { ID = nextID++, Name = name };
            items.Add(IDandNAME);
            Console.WriteLine("New name and Id added. User registered");
        }

        public static IDandNAME Read(int ID)
        {
            return items[ID];           
        }

        public static void Update(int ID, string updatedName)
        {
            var IDandNAME = items[ID];
            if(IDandNAME == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                IDandNAME.Name = updatedName;
                Console.WriteLine("Updayed data:" +  IDandNAME.Name + " - " + IDandNAME.ID);
            }
        }

        public static void Delete(int ID)
        {
            var IDandNAME = items[ID];
            if(IDandNAME != null)
            {
                items.Remove(IDandNAME);
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        public static void ListAll()
        {
            foreach(var IDandNAME in items)
            {
                Console.WriteLine(IDandNAME.Name + "-" + IDandNAME.ID);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var CRUD = new CRUD();
            CRUD.Create("Mary");
            CRUD.Create("16");

            var IDandNAME = CRUD.Read(1);
            Console.WriteLine(IDandNAME.Name, IDandNAME.ID);

            CRUD.Update(1, "");
            CRUD.Delete(2);
            CRUD.ListAll();
        }
    }
}
