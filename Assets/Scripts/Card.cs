using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChaosTheory2810Games
{
    public class Card : ScriptableObject
    {
        public string cardName;
        public string cardNumber;
        public string cardType;
        public enum CardType
        {
            Ape Strength,
            Chimp Speed,
            Potassium Diet,
            Powwah
        }

    }
}