using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clips : MonoBehaviour
{

    public int clips; //currency that can be spent on upgrades and food
    public TextMeshProUGUI display; //displays the number of clips

    public HomunculusStats stats; //grabbing the homunculus stats script

    public int upgradeCost = 100; //starting cost of an upgrade

    public Slider HealthBar; //slider that dislays health
    public Slider DamageBar; //slider that displays strength/damage



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        display.text = clips.ToString(); //translates the clips to string so they can be displayed
    }

    public void feed() //when teh feed button is pressed it costs 5 clips and the homunclus heals
    {
        if (clips >= 5) //if the player has more than 5 clips
        {
            if (stats.displayHealth == stats.health) //if health is max when its pressed then it negates the purchase
            {
                clips += 5;
            }
            clips -= 5; //-5 clips for payment
            stats.displayHealth += 10; //plus 10 to current health
            if (stats.displayHealth > stats.health) //if current health is bigger than max health then its set to max health to avoid going over
            {
                stats.displayHealth = stats.health;
            }

        }
    }

    public void UpgradeSTR() //upgrades strength/damage
    {
        if (clips >= upgradeCost) //if the player has more or equal to teh upgrade cost
        {
            if (stats.displayDamage >= stats.DamageBar.maxValue) //if the stat is at its max then it negates the cost and upgrade
            {
                stats.displayDamage = stats.DamageBar.maxValue -2;//returns value to max
                clips += upgradeCost; //returns the cost
                upgradeCost -= 100; //returns upgrade cost to previus cost so it doesnt go up if you dont spend anything
            }
            clips -= upgradeCost;//- cost for payment
            stats.displayDamage += 2; //adds 2 to stength/damage
            upgradeCost += 100; //increases upgrade cost bt 100


        }
    }

    public void UpgradeHEA() //upgrade max health
    {
        if (clips >= upgradeCost) //if the player has more or equal to teh upgrade cost
        {
            if (stats.displayHealth >= stats.HealthBar.maxValue) //if the stat is at its max then it negates the cost and upgrade
            {
                stats.displayHealth = stats.HealthBar.maxValue -10;//returns value to max
                stats.health = stats.HealthBar.maxValue - 10;//returns value to max
                clips += upgradeCost;//returns the cost
                upgradeCost -= 100; //returns upgrade cost to previus cost so it doesnt go up if you dont spend anything

            }
            if (clips >= upgradeCost) //if the player has more or equal to teh upgrade cost
            {
                clips -= upgradeCost; //- cost for payment
                stats.health += 10; // adds 10 to total health
                stats.displayHealth += 10; //adds 10 to current health
                upgradeCost += 100; //increases upgrade cost bt 100

            }
        }
    }
}


