using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 10.0f;
    protected Rigidbody2D _rb_Paddle;

    private void Awake()
    {
        _rb_Paddle = GetComponent<Rigidbody2D>();
    }
}
