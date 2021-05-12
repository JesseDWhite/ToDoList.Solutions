﻿using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }
    public int Priority { get; set; }
    private static List<Item> _instances = new List<Item> { };
    public static List<Item> GetAll()
    {
      return _instances; //placeholder for whatever you will call in user logic
    }
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public Item(string description, int priority)
      : this(description)
    {
      Priority = priority;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
