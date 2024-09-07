using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI libraries
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Game scene name
    public string SceneName;

    //Start game
    public void OnClickStart()
    {
        //Load game
        SceneManager.LoadScene(SceneName);
    }

    //Exit game
    public void OnClickExit()
    {
        Application.Quit();
        print("Exit was clicked");
    }
}
