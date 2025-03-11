using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrixieMovement : MonoBehaviour
{

    public float speed = 5f;
    public float boundary = 3f; // How far the player can move before the background moves
    public Transform background; // Assign your background object
    public float backgroundSpeed = 2f;

    private Vector2 screenBounds;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

        // Check if the player is within the movement boundary
        if (Mathf.Abs(newPosition.x - startPosition.x) < boundary && Mathf.Abs(newPosition.y - startPosition.y) < boundary)
        {
            transform.position = newPosition; // Move the player normally
        }
        else
        {
            // Move the background instead
            background.position -= new Vector3(moveX * backgroundSpeed, moveY * backgroundSpeed, 0);
        }
    }
}
