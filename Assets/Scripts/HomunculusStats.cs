using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomunculusStats : MonoBehaviour
{
    //stats
    public float health; //health stat
    public float displayHealth;
    public float damage; //damage homunculus can do
    public float displayDamage;
    float attackabsorption; //amount od damage the homunculus can absorb (AO)

    public Slider HealthBar; //slider that dislays health
    public Slider DamageBar; //slider that displays strength/damage
    public Slider healthTracker; // tracks the homonculus's current health

    //display stuff so they can be turned on and off
    public GameObject statbox;
    public GameObject feed;

    public GameObject gameover; //gameover screen

    public Clips clips;

    // Start is called before the first frame update
    void Start()
    {
        health = UnityEngine.Random.Range(10f, 30f); //health is randomly generated between 10 and 30
        damage = UnityEngine.Random.Range(1f, 5f); //damage is randomly generated to start between 1 and 5
        displayHealth = health;
        displayDamage = damage;

        clips.clips = 50;

    }

    // Update is called once per frame
    void Update()
    {
        healthTracker.maxValue = health;
        healthTracker.value = displayHealth;

        HealthBar.value = health; //sets the value of teh slider to the health value
        DamageBar.value = displayDamage;//sets damage/strength to the slider value

        if (displayHealth <= 0)
        {
            gameover.SetActive(true);

        }

    }

    public void gameOver()
    {
        gameover.SetActive(false);
        Start();
    }
    public TextMeshProUGUI Hdisplayed; //display health number
    public GameObject HD; //display
    public TextMeshProUGUI Ddisplayed; //display damage number
    public GameObject DD; //display

    int roundedHealth; // rounded health for display
    int roundedDamage; //rounded damage/strangth for display


    public void healthHover() //hover over health stat
    {
        roundedHealth = Mathf.RoundToInt(health); //rounds to int 
        roundedDamage = Mathf.RoundToInt(damage); // rounds to int

        Hdisplayed.text = roundedHealth.ToString(); //updates the text to be the variable
        HD.SetActive(true); //turns on text
    }

    public void healthHoverOFF() //hover off health stat
    {
       
        HD.SetActive(false); //turns off text
    }

    public void strnegthHover() //hover over strength stat
    {
        roundedHealth = Mathf.RoundToInt(health); //rounds to int 
        roundedDamage = Mathf.RoundToInt(damage); // rounds to int

        Ddisplayed.text = roundedDamage.ToString(); //updates the text to be the variable
        DD.SetActive(true); //turns on text
    }

    public void strnegthHoverOFF() //hover off strength stat
    {

        DD.SetActive(false); //turns off text
    }

}
