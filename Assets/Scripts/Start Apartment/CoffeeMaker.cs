using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeMaker : MonoBehaviour
{
    public SpriteRenderer colliderSr;
    public SpriteRenderer objectSr;
    public Transform plrTrans;

    public bool interactable;
    public bool activate;

    public Sprite empty;
    public Sprite full;

    public TextMeshProUGUI Objective;

    public Slider timer;
    public GameObject timerA;
    public float timerDuration;
    float t;
    bool timeActive = false;

    // Start is called before the first frame update
    void Start()
    {
        objectSr.sprite = empty;

        if (timer != null)
        {
            timer.maxValue = timerDuration;
            timer.value = timerDuration;
        }

        t = timerDuration;

        timerA.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (colliderSr.bounds.Contains(plrTrans.position))
        {
            interactable = true;

        }
        else
        {

            interactable = false;

        }

        if (interactable == true && Input.GetKeyDown(KeyCode.E))
        {
            
            activate = true;
            StartTimer();
            timerA.SetActive(true);

        }

        if (timeActive)
        {
            UpdateTimer();
        }

    }

    void StartTimer()
    {
        t -= Time.deltaTime;

        if(timer != null)
        {
            timer.value = t;
            timeActive = true;
        }

        
        if (t <= 0)
        {
            timeActive = false;
            t = 0;
        }
    }

    void UpdateTimer()
    {
        // Decrease time
        t -= Time.deltaTime;

        // Update slider
        if (timer != null)
        {
            timer.value = t;
        }

        // Stop timer at 0
        if (t <= 0)
        {
            timeActive = false;
            t = 0;
            objectSr.sprite = full;
            timerA.SetActive(false);
            Destroy(timerA);
        }
    }

}


