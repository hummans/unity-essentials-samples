using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Pokemon Command Factory", menuName = "Pokemon/Command/PokemonCmdFactory")]
public class PokemonCmdFactory : ScriptableObject
{
    public PokemonRandomCmd RandomPokemonCmd(int idPokemon, PokemonData pokemonData, MonoBehaviour pokemonInput)
    {
        return new PokemonRandomCmd(idPokemon, pokemonData, pokemonInput, new RandomPokemonGateway("https://pokeapi.co/api/v2/"));
    }
}
