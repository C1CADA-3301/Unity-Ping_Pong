using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Paddle : Paddle
{
   [SerializeField] private Rigidbody2D rb_ball;

   
    private void FixedUpdate()
    {
        if(rb_ball.velocity.x <0.0f)
        {
            if(rb_ball.position.y>this.transform.position.y)
            {
                _rb_Paddle.AddForce(Vector2.up * Speed);
            }
            else if (rb_ball.position.y < this.transform.position.y)
            {
                _rb_Paddle.AddForce(Vector2.down * Speed);
            }
        }

        else
        {
            if(this.transform.position.y>0.0f)
            {
                this._rb_Paddle.AddForce(Vector2.down * Speed);
            }
            else if(this.transform.position.y<0.0f)
            {
                this._rb_Paddle.AddForce(Vector2.up * Speed);
            }
        }
    }

}
