using System;
using System.Collections.Generic;
using System.Linq;
//Pokemon Class - a blueprint for creating Pokemon objects
public class Pokemon
{
    //Attributes - these are variables that hold values
    //about a Pokemon, characteristics of Pokemon
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
} //end pokemon class
// Pokemon LINQ Lab class contains the Main method
// This is the first method that will be called when the program runs
public class PokemonLINQLab
{
    //Main method - entry point of the program
    public static void Main()
    {
        //Sample Data: list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15},
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36},
           new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10},
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22},
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25}
        };
  //Linq Query: find Pokemont that are ready to evolve
        // level 16 for first evolution
        var readyToEvolve = from p in pokemons
                           where p.Level >= 16
                           orderby p.Level
                           select p;
        //Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve:");
        foreach (var p in readyToEvolve)
        {
            //Output the current pokemon who is ready to evolve
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        } //end loop
    }//end main method 
} //end class