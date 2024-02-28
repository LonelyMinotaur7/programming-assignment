using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


// this script houses the functions for the menus to use

public class Menus : MonoBehaviour
{

    public TextMeshProUGUI ScoreText;
    public float highscore = 0;

    public void startgame() // loads game
    {
        SceneManager.LoadScene(1);
        PlayerController.count = 0;
    }

    public void gomenu() // loads main menu
    {
        SceneManager.LoadScene(0);
    }
    
    public void goscore() // loads main menu
    {
        SceneManager.LoadScene(3);
    }

    public void upscore()
    {
        if (PlayerController.count > highscore)
        {
            highscore = PlayerController.count;
            ScoreText.text = highscore.ToString();
            Debug.Log(highscore);
            
        }
    }
    
}
