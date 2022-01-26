using System;
using OopsConcepts.Encapsulation;
using OopsConcepts.Polymorphism.MethodOverloading;
using OopsConcepts.Polymorphism.Method_Over_riding;
using OopsConcepts.ClassObject;
using OopsConcepts.Abstraction;
using OopsConcepts.Interface;
using OopsConcepts.Inheritance;
using OopsConcepts.Constructor;
using OopsConcepts.Pass_by_Value_and_Reference;
using OopsConcepts.Array;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dog dg = new Dog();
            dg.display();
            Pig p = new Pig();
            p.AnimalSound();
            p.Sleep();
            p.Details();*/
            /*Empl1 emp = new Empl1();
            Employee12 e = new Employee12(101, "kiran", 50000);
            e.Display();
            PassByValue.Test();
            PassByReference.TestReferenceType();
            ArrayMultiplication.GetArrrayMultiplication();
            Tiger t=new Tiger();
            t.AnimalSound1();*/
            /*Console.WriteLine("method overloading....");
            Addition add = new Addition();
            add.SumOfNumbers(10, 20, 30);*/
            /*PartTimeEmployee part = new PartTimeEmployee();
            part.GetSalary();
            Addition add = new Addition();
            add.SumOfNumbers(10, 20, 30);
            Dog1 pug = new Dog1();
                        pug.age = 10;
                        pug.breed = "pug";
                        pug.colour = "black";
                        pug.size = 23;
                        pug.sleep();
                        Console.WriteLine("pug details:age;{0},size;{1},color:{2},breed:{3}", pug.age, pug.size, pug.colour, pug.breed);

                        Dog1 labrador = new Dog1();
                        labrador.age = 20;
                        labrador.breed = "labrador";
                        labrador.colour = "white";
                        labrador.size = 23;
                        labrador.sleep();

                        Console.WriteLine("LABRADOR details:age;{0},size;{1},color:{2},breed:{3}", labrador.age, labrador.size, labrador.colour, labrador.breed);

                        Dog1 GSD = new Dog1();
                        GSD.age = 30;
                        GSD.breed = "GSD";
                        GSD.colour = "BLACK COATED";
                        GSD.size = 23;
                        GSD.sleep();
                        Console.WriteLine("GSD details:age;{0},size;{1},color:{2},breed:{3}", GSD.age, GSD.size, GSD.colour, GSD.breed);*/

            /* Account Acc = new Account();
             Acc.setbalance(-1000);
             Acc.GetBalance();*/
            Rectangle Rec = new Rectangle();
            Rec.GetArea();
            Rec.RectangleDetails();
            Rec.display();




            Console.ReadLine();
        }
    }
}
