using ExtensionMethod;
using System;
using System.Collections.Generic;

class Program
{
    static public void Main()
    {
        // Creating a linkedlist
    
        LinkedList<String> my_list = new LinkedList<String>();

        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("Zoya");
        my_list.AddLast("Shilpa");
        my_list.AddLast("Rohit");
        my_list.AddLast("Rohan");
        my_list.AddLast("Juhi");
        my_list.AddLast("Maya");

        Console.WriteLine("Best students of XYZ university initially:");

        // Accessing the elements of

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        // After using Remove(LinkedListNode)
        // method
        Console.WriteLine("Best students of XYZ" +
                         " university in 2000:");

        my_list.Remove(my_list.First);

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        // After using Remove(T) method
        Console.WriteLine("Best students of XYZ" +
                         " university in 2001:");

        my_list.Remove("Rohit");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        // After using RemoveFirst() method
        Console.WriteLine("Best students of XYZ" +
                         " university in 2002:");

        my_list.RemoveFirst();

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        // After using RemoveLast() method
        Console.WriteLine("Best students of XYZ" +
                         " university in 2003:");

        my_list.RemoveLast();

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        // Check if the given element
        // is available or not
        if (my_list.Contains("Shilpa") == true)
        {
            Console.WriteLine("Element Found...!!");
        }
        else
        {
            Console.WriteLine("Element Not found...!!");
        }

        // After using Clear() method
        my_list.Clear();
        Console.WriteLine("Number of students: {0}",
                                     my_list.Count);

        Console.WriteLine();

        // LINQ

        List<string> my_list1 = new List<string>()
        {
                "This is my Dog",
                "Name of my Dog is Robin",
                "This is my Cat",
                "Name of the cat is Mewmew"
        };

        // Creating LINQ Query
        var res = from l in my_list1
                  where l.Contains("my")
                  select l;

        // Executing LINQ Query
        foreach (var q in res)
        {
            Console.WriteLine(q);
        }

        Console.WriteLine();

        // Creating LINQ Query
        // Using Method syntax

        List<string> my_list2 = new List<string>() {
                "This is my car",
                "Model of my car is Mustang",
                "This is my Cat",
                "Name of the cat is Mewmew"
        };

        //Method syntax
        var res1 = my_list2.Where(a => a.Contains("car"));

        // Executing LINQ Query
        foreach (var q in res1)
        {
            Console.WriteLine(q);
        }

        //Extension from program1.cs

        EXT g = new EXT();
        g.M1();
        g.M2();
        g.M3();
        g.M4();
        g.M5("Method Name: M5");

    }

}


