using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Shaun");
            list.AddToEnd("Shaun");
            list.AddToEnd("Jaide");
            list.AddAtStart("Shaun");

            //list.PrintAllNodes

            string getRid = "Shaun";
            list.RemoveAll(getRid);


            
        }
    }
}