// using System;
// using System.Collections.Generic;
// using ToDoList.Models;
// using System.Drawing;
// using Console = Colorful.Console;

// namespace UserInterface
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Welcome to your to-do list.", Color.Green);
//       while (true)
//       {
//         Console.WriteLine("Would you like to add a new item to your list, or view all current items? Add Item/View List", Color.Blue);
//         string userInput = Console.ReadLine();
//         string userAnswer = userInput.ToLower();
//         if (userAnswer == "add item")
//         {
//           Console.WriteLine("Great! What would you like to add?", Color.Green);
//           string description = Console.ReadLine();
//           Console.WriteLine("What priority level is this item?", Color.Green);
//           string priorityString = Console.ReadLine();
//           int priorityLevel = int.Parse(priorityString);
//           Item newItem = new Item(description, priorityLevel);//descrption doesnt matter anymore because we are able to access a numeric value of priority level. Give the user access to description so they know what they are looking for. In the background, we will using the priority level because it is easier to add logic to numeric values.
//           List<Item> newList = new List<Item> { newItem };
//           Console.WriteLine(description + " has been added to your list.", Color.Green);
//         }
//         else if (userAnswer == "view list")
//         {
//           List<Item> result = Item.GetAll();
//           foreach (Item individualItem in result)
//           {
//             Console.WriteLine(individualItem.Description, Color.Red);
//           }
//         }
//         else
//         {
//           Console.WriteLine("I'm sorry, that is not a command. Please enter a correct command.", Color.Red);
//         }
//       }
//     }
//   }
// }
