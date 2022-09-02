using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{

    public static UI_Manager _Instance { get; private set; }

    private void Awake()
    {
        _Instance = this;
    }

    [SerializeField] private Text Score1_txt;
    [SerializeField] private Text Score2_txt;

    [SerializeField] public int Score1_int = 0;
    [SerializeField] public int Score2_int = 0;

    [SerializeField] public int Score_Limit = 10;

    [SerializeField] private Text won_txt;

    [SerializeField] GameObject gameOver_panel;

    [SerializeField] public string player_sq;
    void Start()
    {
        Score1_int = 0;
        Score2_int = 0;
        gameOver_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score1()
    {
        Score1_int++;
        Score1_txt.text = Score1_int.ToString();

        if(Score1_int == Score_Limit)
        {
            player_sq = "AI";
            Game_Manager._Instance.GameOver();
        }

    }

    public void Score2()
    {
        Score2_int++;
        Score2_txt.text = Score2_int.ToString();
        if (Score2_int == Score_Limit)
        {
            player_sq = "You";
            Game_Manager._Instance.GameOver();
        }

    }

    public void GameOverUI()
    {
        
        gameOver_panel.SetActive(true);
        won_txt.text = player_sq + "WON!";

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
