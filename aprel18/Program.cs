﻿using aprel18.Models;
using System.Reflection;

namespace aprel18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringArrayList list = new StringArrayList();
            //list.Add(1);
            //list.Add(22);
            //list.Add(31);
            //list.Add(21);

            //list.GetElements();
            //StringArrayList strs = new StringArrayList();
            //strs.Add("salam");
            //strs.Add("aleykum");
            //strs.GetElements();
            //    ObjectArrayList obj = new ObjectArrayList(typeof(Int32));
            //    obj.Add(12);
            //    obj.add(true);
            //    obj.add("salam");
            //    obj.GetElements();


            //}
            //class ObjectArrayList
            //{
            //    public string[] _arr;
            //    public int Capacity { get; set; }
            //    public int Count { get; set; }

            //    public ObjectArrayList()
            //    {
            //        _arr = new string[Capacity];
            //    }
            //    public ObjectArrayList(int capacity)
            //    {
            //        Capacity = capacity;
            //        _arr = new string[Capacity];
            //    }
            //    public ObjectArrayList(int capacity, Type listType)
            //    {
            //        Capacity=capacity;
            //        _arr = new object[Capacity];
            //        _listType=listType;

            //    }
            //    public void Add(string value)
            //    {
            //        if (value.GetType().Name== _listType.Name)
            //        {

            //            if (_arr.Length == Count)
            //            {
            //                Array.Resize(ref _arr, Count + Capacity);
            //            }
            //            _arr[Count] = value;
            //            Count++;
            //        }

            //    }
            //    public void GetElements()
            //    {
            //        for (int i = 0; i < Count; i++)
            //        {
            //            Console.WriteLine(_arr[i]);
            //        }

            //    }
            //}




            //Apple apple = new Apple(20,30,50m,"qizilehmedi");
            //Pineapple pineapple = new Pineapple(10,40,100m,"afrika");
            //Orange orange = new Orange(60,70m,"lenkeran");
            //Fruit[] Basket = {apple, pineapple, orange}; 
            //foreach (Fruit fruit in Basket )
            //{
            //Apple app = fruit as Apple;
            //Pineapple pine = fruit as Pineapple;
            //Orange org=fruit as Orange;

            //if (app != null )
            //{
            //    Console.WriteLine(app.VitaminA);
            //}
            //if ( pine != null )
            //{
            //    Console.WriteLine(pine.VitaminE);
            //}
            //if ( org != null )
            //{
            //    Console.WriteLine(org.VitaminC);
            //}

            //if (fruit is Apple app)
            //{
            //    Console.WriteLine(app.Sort+ app.VitaminA+ " " + app.VitaminB);
            //}
            //else if (fruit is Pineapple pine)
            //{
            //    Console.WriteLine(pine.Sort + pine.VitaminE + " " + pine.VitaminD);
            //}
            //else if (fruit is Orange org)
            //{
            //    Console.WriteLine(org.Sort +  " " + org.VitaminC);

            //}



            //    Type fruitType = fruit.GetType();
            //    Console.WriteLine($"Meyvenin tipi: {fruitType.Name}");
            //    FieldInfo[] fields = fruitType.GetFields();
            //    foreach (FieldInfo fi in fields )
            //    {
            //        Console.WriteLine($"{fi.Name}:{fi.GetValue(fruit)}");
            //    }

            //}



            Cow cow = new Cow("grass");
            Lion lion = new Lion("meat");
            Animal[] animals = { cow, lion };

            foreach (var animal in animals)
            {
                if (animal is Cow)
                {
                    Cow cow1 = (Cow)animal;
                    Meat grass = new Meat("ot", 100);
                    cow.EatFood(grass);
                }
                if (animal is Cow)
                {
                    Cow cow1 = (Cow)animal;
                    Grass grass = new Grass("ot", 100);
                    cow.EatFood(grass);
                }
                else if (animal is Lion)
                {
                    Lion lion1 = (Lion)animal;
                    Meat meat = new Meat("et", 200);
                    lion.EatFood(meat);
                }
            }
        }
    }
    }

