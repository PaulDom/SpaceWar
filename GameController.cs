using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float gameSpeed = 1;

    [Range(1, 2)]
    public float gameSpeedRegulator;
    public float speedRate = 0.05f;
    public float gameSpeedMax = 2;

    private void Update()
    {
        if (gameSpeedRegulator < gameSpeedMax)
        {
            gameSpeedRegulator += speedRate*Time.deltaTime;
        }
        gameSpeed = gameSpeedRegulator;
    }
}
