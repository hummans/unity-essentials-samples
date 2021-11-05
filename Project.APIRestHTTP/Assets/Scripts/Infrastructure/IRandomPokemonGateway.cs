using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public interface IRandomPokemonGateway
{
    string basePokeURL {get; set;}
    IObservable<Unit> GetRandomPokemon(int id, PokemonData pokemon, MonoBehaviour pokemonInput);
}
