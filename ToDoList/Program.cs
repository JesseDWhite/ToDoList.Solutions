using System;
using System.Collections.Generic;
using ToDoList.Models;
using System.Drawing;
using Console = Colorful.Console;

namespace UserInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your to-do list.", Color.Green);
      while (true)
      {
        Console.WriteLine("Would you like to add a new item to your list, or view all current items? Add Item/View List", Color.Blue);
        string userInput = Console.ReadLine();
        string userAnswer = userInput.ToLower();
        if (userAnswer == "add item")
        {
          Console.WriteLine("Great! What would you like to add?", Color.Green);
          string description1 = Console.ReadLine();
          Item newItem = new Item(description1);
          List<Item> newList = new List<Item> { newItem };
          Console.WriteLine(description1 + " has been added to your list.", Color.Green);
        }
        else if (userAnswer == "view list")
        {
          List<Item> result = Item.GetAll();
          foreach (Item individualItem in result)
          {
            Console.WriteLine(individualItem.Description, Color.Red);
          }
        }
        else
        {
          Console.WriteLine("I'm sorry, that is not a command. Please enter a correct command.", Color.Red);
        }
      }
    }
  }
}