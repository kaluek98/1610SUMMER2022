using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;
   
   void Awake()
   {
    Time.timeScale = 1;
    isGameOver = false;
   }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

   
    void Update()
    {
        if(Time.timeScale == 0) // I'm not sure how yours worked but isGameOver never became true so I had to change the code to Time.timeScale for the GAME OVER text to appear
        {
            EndGame();
        }
       else
         gameOverText.gameObject.SetActive(false); // keep UI Text Game Over hidden
    }   
    
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; // freeze time
    } 

}
