using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class JellyBaby : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator animator;

    public Vector2 move;

    public SpriteRenderer sr;

    public Vector2 pointA;
    public Vector2 pointB;
    public Vector2 pointC;
    public Vector2 pointD;
    public float point;

    public float t;

    float speed = 8;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        t += Time.deltaTime/speed;
        if (point == 1)
        {
            transform.position = Vector2.Lerp(pointA, pointB, t);
        }
        if (point == 2)
        {
            speed = 4;
            transform.position = Vector2.Lerp(pointB, pointC, t);
            
        }
        if (point == 3)
        {
            speed = 6;
            transform.position = Vector2.Lerp(pointC, pointD, t);
            
        }
        if (point == 4)
        {
            transform.position = pointD;
        }

        

        if (t >= 1 && point != 4)
        {
            t = 0;
            point += 1;
        }

       
    }
}
