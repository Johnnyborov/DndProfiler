﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraper.Models
{
  public class Ability
  {
    public int id;

    public int level;
    public string name;
    public string description;

    public List<Option> options;
    public List<int> increases;

    public Dictionary<string, int> stats;


    public void FillStats()
    {
      stats = new Dictionary<string, int>();
    }
  }
}
