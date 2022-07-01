using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;
    public Text happynessText;
    
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        happynessText.text = card.happyness.ToString(" In terms of happyness he's at a " + card.happyness + " out of 10.");

    }

}
