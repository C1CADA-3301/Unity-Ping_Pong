using UnityEngine;

public class Player_Paddle : Paddle
{
   private Vector2 _Direction;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _Direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _Direction = Vector2.down;
        }
        else
        {
            _Direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(_Direction.sqrMagnitude!=0)
        {
            _rb_Paddle.AddForce(_Direction * Speed);
        }
    }
}
