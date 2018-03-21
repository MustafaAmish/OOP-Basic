using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTrainer;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name,Pokemon pokemon)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new List<Pokemon>
        {
            pokemon
        };
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.Pokemons.Add(pokemon);
    }

    public void PokemonDmg()
    {
        int count = this.Pokemons.Count;
        var pkRemove=new List<int>();
        for (int i = 0; i < count; i++)
        {
            this.Pokemons[i].Healt -= 10;
           
        }
        this.Pokemons=new List<Pokemon>(this.Pokemons.Where(x=>x.Healt>0));
    }

    

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can not be empty.");
            }

            this.name = value;
        }
    }

}

