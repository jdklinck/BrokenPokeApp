using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private readonly List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public bool UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = GetPokemonByTeamPosition(teamPosition);
            if (pokemon != null)
            {
                pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
                pokemon.PokemonNickName = updates.PokemonNickName;
                pokemon.Level = updates.Level;
                pokemon.PokemonType = updates.PokemonType;
                pokemon.SecondaryType = updates.SecondaryType;
                pokemon.MoveOne = updates.MoveOne;
                pokemon.MoveTwo = updates.MoveTwo;
                pokemon.MoveThree = updates.MoveThree;
                pokemon.MoveFour = updates.MoveFour;
                return true;
            }
            else
            {
                return false;
            }
        }
        //remove pokemon
        public bool RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = GetPokemonByTeamPosition(teamPosition);
            if (pokemon == null)
            {
                return false;
            }
            int initialCount = _pokemonTeam.Count;
            _pokemonTeam.Remove(pokemon);
            if (initialCount > _pokemonTeam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            foreach (Pokemon p in _pokemonTeam)
            {
                if (nickName == p.PokemonNickName)
                {
                    p.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                    p.PokemonNickName = newPokemon.PokemonNickName;
                    p.Level = newPokemon.Level;
                    p.PokemonType = newPokemon.PokemonType;
                    p.SecondaryType = newPokemon.SecondaryType;
                    p.MoveOne = newPokemon.MoveOne;
                    p.MoveTwo = newPokemon.MoveTwo;
                    p.MoveThree = newPokemon.MoveThree;
                    p.MoveFour = newPokemon.MoveFour;
                }
            }
        }

    }
}
