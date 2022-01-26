
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;
using TMPro;

public class PokemonInformationDisplay : MonoBehaviour
{
    public TextMeshProUGUI pokeNameText, pokeIdText;
    public RawImage pokeImage;
    public TextMeshProUGUI[] pokeTypes;

    [Header("References")]
    public PokemonData pokemonData;

    void Start()
    {
        pokemonData.OnPokemonLoading
            .Subscribe(LoadingData)
            .AddTo(this);

        pokemonData.OnPokemonLoadData
            .Subscribe(OnLoadData)
            .AddTo(this);
    }
    private void LoadingData(int id)
    {
        pokeIdText.text = "#" + id;
        pokeNameText.text = "Loading...";
        foreach(TextMeshProUGUI poke in pokeTypes)
        {
            poke.text = "";
        }
    }
    private void OnLoadData(Pokemon pokemon)
    {
        pokeIdText.text = "#" + pokemon.pokemonId.ToString();

        pokeImage.texture = pokemon.pokemonImage;
        pokeImage.texture.filterMode = FilterMode.Point;

        pokeNameText.text = CapitalizeFirstLetter(pokemon.pokemonName);

        for (int i = 0; i < pokemon.pokemonType.Length; i++)
        {
            pokeTypes[i].text = CapitalizeFirstLetter(pokemon.pokemonType[i].ToString());
        }
    }

    private string CapitalizeFirstLetter(string str)
    {
        return char.ToUpper(str[0]) + str.Substring(1);
    }
}
