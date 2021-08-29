using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonRandomInput : MonoBehaviour
{
    public PokemonCmdFactory pokemonCmdFactory;
    public PokemonData pokemonData;

    [ContextMenu("OnClick Test")]
    public void OnClick()
    {
        int id = Random.Range(1, 808);
        pokemonCmdFactory.RandomPokemonCmd(id, pokemonData, this).Execute();
    }
}
