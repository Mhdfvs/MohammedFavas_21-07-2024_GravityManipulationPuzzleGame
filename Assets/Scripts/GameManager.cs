using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;
    public int timeValue =120;
    private int collectedCubes;
    private int totalCubes;
    private void Start()
    {
        InvokeRepeating("Timer", 0, 1);
    }
    void Timer()
    {
        if (timeValue <= 0)
        {
            GameOver();
            return;
        }
        timeValue--;
        int minutes = timeValue / 60;
        int seconds = timeValue - minutes * 60;
        timerText.text = "Time: " + minutes + "M: " + seconds + "S";
    }
    void GameOver()
    {
        Time.timeScale = 0;
    }
    public void CollectCube()
    {
        collectedCubes++;
        if (collectedCubes >= totalCubes)
        {
            //WinGame();
        }
    }
    private void WinGame()
    {
        Debug.Log("Cube Collected");
    }
}