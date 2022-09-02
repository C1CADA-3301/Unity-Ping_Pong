using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour_Changer : MonoBehaviour
{
    public SpriteRenderer Score_Wall;
    public Color[] colorArray;
    private int i = 0;
    public float speed = 0.2f;
    public float timer=0;

    private void Awake()
    {
        Score_Wall = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if(timer<=colorArray.Length-1)
        {
            Score_Wall.material.color = Color.Lerp(Score_Wall.material.color, colorArray[i], speed * Time.deltaTime);
        }
       

        timer = Mathf.Lerp(timer, 1f, speed * Time.deltaTime);
        if(timer>0.9f)
        {
            timer = 0;
            i++;
            i = i >= colorArray.Length ? 0 : i;
        }
        //Debug.Log(timer);

      


    }
}
