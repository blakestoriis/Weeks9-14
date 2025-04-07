using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
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

    //the select buttons
    public GameObject start;

    //display stuff so they can be turned on and off
    public GameObject statbox;
    public GameObject feed;

    // Start is called before the first frame update
    void Start()
    {
        health = UnityEngine.Random.Range(10f, 30f); //health is randomly generated between 10 and 30
        damage = UnityEngine.Random.Range(1f, 5f); //damage is randomly generated to start between 1 and 5
        displayHealth = health;
        displayDamage = damage;
        
    }

    // Update is called once per frame
    void Update()
    {
        healthTracker.maxValue = health;
        healthTracker.value = displayHealth;

        HealthBar.value = health; //sets the value of teh slider to the health value
        DamageBar.value = displayDamage;//sets damage/strength to the slider value
    }

    //selecting a homunculus only changes appearance
    public void H1() //homunculus 1
    {
        //turns off the select homunculus buttons and turns on the stats and display stuff
        start.SetActive(false);
        feed.SetActive(true);
        statbox.SetActive(true);
        
    }

}
