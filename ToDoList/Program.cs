using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace UserInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your to-do list.");
      while (true)
      {
        Console.WriteLine("Would you like to add a new item to your list, or view all current items? Add Item/View List");
        string userInput = Console.ReadLine();
        string userAnswer = userInput.ToLower();
        if (userAnswer == "add item")
        {
          Console.WriteLine("Great! What would you like to add?");
          string description1 = Console.ReadLine();
          Item newItem = new Item(description1);
          List<Item> newList = new List<Item> { newItem };
          Console.WriteLine(description1 + " has been added to your list.");
        }
        else
        {
          List<Item> result = Item.GetAll();
          foreach (Item individualItem in result)
          {
            Console.WriteLine(individualItem.Description);
          }
        }
      }
    }
  }
}





// string description01 = Console.ReadLine() "Walk the dog";
// string description02 = "Wash the dishes";
// Item newItem1 = new Item(description01);
// Item newItem2 = new Item(description02);
// List<Item> newList = new List<Item> { newItem1, newItem2 };