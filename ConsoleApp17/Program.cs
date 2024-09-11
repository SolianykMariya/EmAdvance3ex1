using System;
using System.Collections.Generic;

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
            return items.Find(value => value.ID == ID);           
        }

        public static void Update(int ID, string updatedName)
        {

            IDandNAME IDandNAME = items.Find(value => value.ID == ID);

            if (IDandNAME == null)
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
            if(items.Remove(items.Find(value => value.ID == ID)))
            {
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
