using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using SimpleJSON;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;

public class RandomPokemonGateway : IRandomPokemonGateway
{
    public string basePokeURL {get; set;}

    public RandomPokemonGateway(string pokeUrl)
    {
        this.basePokeURL = pokeUrl;
    }

    public IObservable<Unit> GetRandomPokemon(int idPokemon, PokemonData pokemonData, MonoBehaviour pokemonInput)
    {
        pokemonData.OnPokemonLoading.OnNext(idPokemon);

        return Observable.Return(Unit.Default)
            .Do(_ => pokemonInput.StartCoroutine(GetPokemonAtIndex(idPokemon, pokemonData)))
            //.Delay(TimeSpan.FromMilliseconds(1000))
            .Do(_ => Debug.Log("Getting from API("+basePokeURL+") pokemon with id: " + idPokemon));
    }
    IEnumerator GetPokemonAtIndex(int idPokemon, PokemonData pokemonData)
    {
        string pokemonURL = basePokeURL + "pokemon/" + idPokemon.ToString();
        UnityWebRequest pokeInfoRequest = UnityWebRequest.Get(pokemonURL);

        yield return pokeInfoRequest.SendWebRequest();

        if(pokeInfoRequest.result == UnityWebRequest.Result.ConnectionError || pokeInfoRequest.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("UnityWebRequest: " + pokeInfoRequest.error);
            yield break;
        }

        JSONNode pokeInfo = JSON.Parse(pokeInfoRequest.downloadHandler.text);

        string pokeName = pokeInfo["name"];
        string pokeSpriteUrl = pokeInfo["sprites"]["front_default"];
        JSONNode pokeTypes = pokeInfo["types"];
        string[] pokeTypeNames = new string[pokeTypes.Count];

        for (int i = 0, j = pokeTypes.Count - 1; i < pokeTypes.Count; i++, j--)
        {
            pokeTypeNames[j] = pokeTypes[i]["type"]["name"];
        }

        UnityWebRequest pokeSpriteRequest = UnityWebRequestTexture.GetTexture(pokeSpriteUrl);
        yield return pokeSpriteRequest.SendWebRequest();

        Pokemon info = new Pokemon();
        info.pokemonName = pokeName;
        info.pokemonId = idPokemon.ToString();
        info.pokemonImage = DownloadHandlerTexture.GetContent(pokeSpriteRequest);
        info.pokemonType = pokeTypeNames;

        pokemonData.OnPokemonLoadData.OnNext(info);
        Debug.Log("Loading Pokemon: " + pokeName);
    }
}
