using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    public Vector2 movement;
    public float timeLeft;
    private float a;
    public SpriteRenderer sprite;

    void Start()
    {
        a = Random.Range(-0.2f, 0.2f);
        accelerationTime = accelerationTime + a;
    }


    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Move();
            timeLeft += accelerationTime;
        } 
    }

    

    void OnCollisionEnter2D(Collision2D collision)
    {
        //sprite.color = Color.green;
       // print("oui");
       // Move();
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //sprite.color = Color.blue;
        // Move();
    }

    void Move()
    {
        movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb.velocity = (movement * maxSpeed);
    }
}
