using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace server.Models
{
  public class Character
  {
    public Character() {}
    public Character(Character c)
    {
      Class = c.Class;
      Subclass = c.Subclass;
      Level = c.Level;

      Stats = c.Stats;
      Abilities = c.Abilities;
      Feats = c.Feats;
      Cantrips = c.Cantrips;
      Spells = c.Spells;
    }

    public string Class { get; set; }
    public string Subclass { get; set; }
    public int Level { get; set; }

    [NotMapped]
    public List<int> Stats { get; set; }

    [NotMapped]
    public List<int> Abilities { get; set; }

    [NotMapped]
    public List<int> Feats { get; set; }

    [NotMapped]
    public List<int> Cantrips { get; set; }

    [NotMapped]
    public List<int> Spells { get; set; }
  }

  public class CharacterSerialized: Character
  {
    public CharacterSerialized() {}
    public CharacterSerialized(Character c) : base(c) {}

    [Key]
    public long Id { get; set; } 


    [Column("Stats")]
    public string StatsSerialized
    {
      get
      {
        return JsonConvert.SerializeObject(Stats);
      }
      set
      {
        Stats = string.IsNullOrEmpty(value) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(value);
      }
    }

    [Column("Abilities")]
    public string AbilitiesSerialized
    {
      get
      {
        return JsonConvert.SerializeObject(Abilities);
      }
      set
      {
        Abilities = string.IsNullOrEmpty(value) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(value);
      }
    }

    [Column("Feats")]
    public string FeatsSerialized
    {
      get
      {
        return JsonConvert.SerializeObject(Feats);
      }
      set
      {
        Feats = string.IsNullOrEmpty(value) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(value);
      }
    }

    [Column("Cantrips")]
    public string CantripsSerialized
    {
      get
      {
        return JsonConvert.SerializeObject(Cantrips);
      }
      set
      {
        Cantrips = string.IsNullOrEmpty(value) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(value);
      }
    }

    [Column("Spells")]
    public string SpellsSerialized
    {
      get
      {
        return JsonConvert.SerializeObject(Spells);
      }
      set
      {
        Spells = string.IsNullOrEmpty(value) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(value);
      }
    }
  }
}