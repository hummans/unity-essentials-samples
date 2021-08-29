using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using ViewModel;

namespace Components
{
    public class CardNameDisplay : MonoBehaviour
    {
        public CardData cardData;
        public TextMeshProUGUI nameText;
        public TextMeshProUGUI descriptionText;

        public Image panelImage;
        public TextMeshProUGUI manaText;
        public TextMeshProUGUI healthText;
        public TextMeshProUGUI attackText;

        public void Start()
        {
            //cardData.nameCard.Subscribe(UpdateName)
            //                 .AddTo(this);
            UpdateName();
            UpdateData();                    
        }

        private void UpdateName()
        {
            nameText.text = name;
        }

        private void UpdateData()
        {
            descriptionText.text = cardData.description;

            panelImage.color = cardData.artWork;
            manaText.text = "Cost: " + cardData.cost.ToString();
            attackText.text = "Attack: " + cardData.attack.ToString();
            healthText.text = "Health: " + cardData.health.ToString();
        }
    }
}
