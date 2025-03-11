using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator animator;

    public Vector2 move;

    public SpriteRenderer sr;

    public float speed;

    //audio
    public AudioSource source;
    public AudioClip pickUp;

    //public SceneCount SceneCount;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            move.y = Input.GetAxis("Vertical");
            move.x = Input.GetAxis("Horizontal");

            animator.SetFloat("speedY", move.y * speed);
            animator.SetFloat("speedX", move.x * speed);

            if (Input.GetKeyDown(KeyCode.E))
            {

                //animator.SetBool("interact", true);
                //source.PlayOneShot(pickUp);
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                //.SetBool("interact", false);

            }

            rb.velocity = new Vector3(move.x * speed, move.y * speed, 0);

        
    }
}
