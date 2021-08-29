using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemon/Data/PokemonData")]
public class PokemonData : ScriptableObject
{ 
    public ISubject<int> OnPokemonLoading = new Subject<int>();    
    public ISubject<Pokemon> OnPokemonLoadData = new Subject<Pokemon>();    
}
