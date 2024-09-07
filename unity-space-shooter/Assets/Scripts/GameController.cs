using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Game speed
    public static float gameSpeed;
    [Range(0, 5)]
    //Game speed regulator
    public float gameSpeedRegulator = 3f;
    //Speed rate
    public float speedRate = 0.5f;
    //Speed max
    public float gameSpeedMax = 5;

    // Update is called once per frame
    void Update()
    {
        //If gameSpeedRegulator is equal or less than gameSpeedMax
        if (gameSpeedRegulator <= gameSpeedMax)
        {
            //Update gameSpeedRegulator
            gameSpeedRegulator += speedRate * Time.deltaTime;
        }
        //Set new value
        gameSpeed = gameSpeedRegulator;
    }
}
