using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager _Instance { get; private set; }

    public bool IsGameOver;

    

    private void Awake()
    {
        _Instance = this;
    }
    void Start()
    {
        Time.timeScale = 1;
        IsGameOver = false;
    }

    // Update is called once per frame
    public void GameOver()
    {

        Time.timeScale = 0;
    }
}
