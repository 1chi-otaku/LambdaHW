using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace LambdaHW
{
    delegate void Delegate();
    struct BackPackObject
    {

        public string name { get; set; }
        public double capacity { get; set; }
        public BackPackObject(string name, double capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }
        public void Print()
        {
            Console.WriteLine("Object - " + name);
            Console.WriteLine("Capacity - " + capacity);
        }
    }
    class Backpack
    {
        public event Delegate AddItem;
        Color colour;
        String creator;
        String textile;
        double weight;
        double capacity;
        BackPackObject[] objects { get; set; }

        public Backpack()
        {
            colour = Color.Black;
            creator = "N/A";
            textile = "N/A";
            weight = 1.0;
            capacity = 0.8;
            objects = new BackPackObject[0];
        }
        public Backpack(Color colour, string creator, string textile, double weight, double capacity, BackPackObject[] objects)
        {
            this.colour = colour;
            this.creator = creator;
            this.textile = textile;
            this.weight = weight;
            this.capacity = capacity;
            this.objects = objects;
        }
        public Backpack(Color colour, string creator, string textile, double weight, double capacity, int size)
        {
            this.colour = colour;
            this.creator = creator;
            this.textile = textile;
            this.weight = weight;
            this.capacity = capacity;
            objects = new BackPackObject[size];
        }
        public void Init()
        {
            Console.WriteLine("Enter creator:");
            creator = Console.ReadLine();
            Console.WriteLine("Enter textile:");
            textile = Console.ReadLine();
            Console.WriteLine("Enter weight:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter capacity:");
            capacity = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine("Object #:" + i + 1);
                Console.Write("Enter name: ");
                objects[i].name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter capacity: ");
                objects[i].capacity = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void Print()
        {
            Console.WriteLine("Creator - " + creator);
            Console.WriteLine("Textile - " + textile);
            Console.WriteLine("Weight - " + weight);
            Console.WriteLine("Capacity - " + capacity);
            Console.WriteLine("Colour - " + colour.Name);
            Console.WriteLine("-------------------------\nBackpack content:");
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine(i + 1 + ") ");
                objects[i].Print();
            }
            Console.WriteLine("-------------------------");
        }

        public void AddAnItem(BackPackObject obj)
        {
            if (this.capacity - obj.capacity < 0)
            {
                throw new Exception("Capacity Exception");
            }
            BackPackObject[] temp = new BackPackObject[objects.Length + 1];
            int i = 0;
            for (i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = objects[i];
            }
            temp[i] = obj;
            objects = temp;
            this.capacity -= obj.capacity;
            AddItem?.Invoke();
        }


        //    public static Backpack operator +(Backpack op1, BackPackObject op2)
        //    {
        //        if (op1.capacity - op2.capacity < 0)
        //        {
        //            throw new Exception("Capacity Exception");
        //        }
        //        BackPackObject[] temp = new BackPackObject[op1.objects.Length + 1];
        //        int i = 0;
        //        for (i = 0; i < temp.Length-1; i++)
        //        {
        //            temp[i] = op1.objects[i];
        //        }
        //        temp[i] = op2;
        //        op1.objects = temp;
        //        op1.capacity -= op2.capacity;
        //        return op1;
        //    }
        //}
    }
    //class Observer
    //{
    //    public static void ObjectAdd()
    //    {
    //        Console.WriteLine("Object was added!");
    //    }
    //}
}
