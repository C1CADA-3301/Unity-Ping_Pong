using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_UI_Manager : MonoBehaviour
{
    public Text PingPong;
    public Color[] ColorUI;
    private int i = 0;
    private float timer = 0;
    public float speed = 0.2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PingPong.color = Color.Lerp(PingPong.color, ColorUI[i], speed * Time.deltaTime);
        timer = Mathf.Lerp(timer, 1, speed * Time.deltaTime);
        if(timer>0.9f)
        {
            timer = 0;
            i++;
            i = i >= ColorUI.Length ? 0 : i;
        }

    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
