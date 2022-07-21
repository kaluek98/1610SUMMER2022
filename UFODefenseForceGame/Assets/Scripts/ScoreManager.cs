using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // text mesh pro name space added to access the unity librarys for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // keep our score value
    public TextMeshProUGUI scoreText; // Visual Text element to be modified
   
   public void IncreaseScore(int amount) // This method when called increases the score by a predetrmied amount set in score variable
    {

        score += amount;
        UpdateScoreText();
    }
    public void DecreaseScore(int amount) // This method when called decreases the score by a predetermined amount set in score variable    
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // this method updates the score in the HUD UI Text
    {
        scoreText.text = "Score: "+ score;
    }
}
