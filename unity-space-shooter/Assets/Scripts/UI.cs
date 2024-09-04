using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI libraries
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    //Player
    public Player player;
    //Score
    public TextMeshProUGUI scoreText;
    //Restart canvas
    public Canvas restartUi;

    // Update is called once per frame
    void Update()
    {
        //Set score on screen
        scoreText.SetText(player.points.ToString());
        //Show restart ui canvas
        RestartUiController();
    }

    //Show restart ui canvas
    void RestartUiController()
    {
        //On player defeat
        if (player == null)
        {
            //Show canvas
            restartUi.gameObject.SetActive(true);
        }
    }

    //Restart game
    public void RestartGame()
    {
        //Get scene index
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Load scene
        SceneManager.LoadScene(sceneIndex);
    }
}
