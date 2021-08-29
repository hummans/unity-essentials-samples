using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "NewCardData", menuName= "Data/Card")]
    public class CardData : ScriptableObject
    {
        public ISubject<StringReactiveProperty> nameCard = new Subject<StringReactiveProperty>();    
        [TextArea]
        public string description;

        public Color artWork;

        public int cost;
        public int attack;
        public int health;
    }
}
