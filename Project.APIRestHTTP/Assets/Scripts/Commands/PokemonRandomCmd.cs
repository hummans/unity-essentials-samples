using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class PokemonRandomCmd : ICommand
{
    private readonly int idPokemon;
    private IRandomPokemonGateway gateway;
    private PokemonData pokemonData;
    private readonly MonoBehaviour pokemonInput;

    public PokemonRandomCmd(int idPokemon, PokemonData pokemon, MonoBehaviour pokemonInput, IRandomPokemonGateway gateway)
    {
        this.idPokemon = idPokemon;
        this.gateway = gateway;
        this.pokemonData = pokemon;
        this.pokemonInput = pokemonInput;
    }

    public void Execute()
    {   
        // Getting the pokemon
        gateway.GetRandomPokemon(idPokemon, pokemonData, pokemonInput)
        .Subscribe();
    }
}
