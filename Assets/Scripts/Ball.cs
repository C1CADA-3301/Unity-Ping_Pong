using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb_Ball;
    [SerializeField] private float Ball_Speed = 200f;
    [SerializeField] private float Bounce_Strength = 5f;
    //[SerializeField] private Text Score1_txt;
    //[SerializeField] private Text Score2_txt;

    //[SerializeField] private int Score1_int = 0;
    //[SerializeField] private int Score2_int = 0;
    //[SerializeField] private int Score_Limit = 10;


    private Vector2 ball_Direction;

    private void Awake()
    {
        _rb_Ball = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        StartDirection();
    }
    void StartDirection()
    {
        float x = Random.value < 0.5f ? -1.0f:1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);
        ball_Direction = new Vector2(x, y);
        _rb_Ball.AddForce(ball_Direction * Ball_Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_rb_Ball != null)
        {
            if(collision.collider.CompareTag("Right_Wall") || collision.collider.CompareTag("Left_Wall"))
            {
                _rb_Ball.position = Vector2.zero;
                _rb_Ball.velocity = Vector2.zero;
                StartDirection();

                if (collision.collider.CompareTag("Right_Wall"))
                {
                    //Score1_int++;
                    //Score1_txt.text = Score1_int.ToString();
                    //if(Score1_int==Score_Limit)
                    //{
                    //    Time.timeScale = 0;
                    //}

                    UI_Manager._Instance.Score1();
                }
                if (collision.collider.CompareTag("Left_Wall"))
                {
                    //Score2_int++;
                    //Score2_txt.text = Score2_int.ToString();
                    //if (Score2_int == Score_Limit)
                    //{
                    //    Time.timeScale = 0;
                    //}
                    UI_Manager._Instance.Score2();
                }
            }
            else
            {
                if (_rb_Ball.velocity.magnitude < 10f)
                {
                    Vector2 Normal = collision.GetContact(0).normal;
                    _rb_Ball.AddForce(Normal * this.Bounce_Strength);

                }
              
            }
            
            Debug.Log(_rb_Ball.velocity.magnitude);

        }
        
    }
}
