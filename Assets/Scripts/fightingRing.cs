using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fightingRing : MonoBehaviour
{

    //other UIs that get turned on and off
    public GameObject statbox;
    public GameObject feed;

    public HomunculusStats stats; //collects the stats to create win chance
    public float score; //player score
    public float oppscore; //opponents score
    public float winChance; //calculated chance of winning between 5% and 95%
    public int rounded; // rounded value of win chance

    public TextMeshProUGUI display; //displays the win chance
    public GameObject buttons;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = stats.health + stats.damage; //score is calculated by adding teh players health and strength togather to get a score that has a max of 120
         rounded = Mathf.RoundToInt(winChance); //rounds winchance to an int
    }

    public void ClickFight() //when the fight button is pressd it hides all the currently active UI and shows the new pages UI
    {
        feed.SetActive(false);
        statbox.SetActive(false);
    }

    public void leaveFight() //turns off fight page UI and turns on main page UI
    {
        feed.SetActive(true);
        statbox.SetActive(true);
    }

    public void lvl1 () //first level opponents have a score of 20-40
    {

        buttons.SetActive(false);

        oppscore = Random.Range(20f, 40f);
        winChance = 95 -(oppscore - score);
        if (winChance >= 95)
        {
            winChance = 95;
        }
        if (winChance <= 5)
        {
            winChance = 5;
        }
        display.text = rounded.ToString() + "%";
    }


    public void lvl2() //second level opponents have a score of 40-60
    {

        buttons.SetActive(false);

        oppscore = Random.Range(40f, 60f);
        winChance = 95 - (oppscore - score);
        if (winChance >= 95)
        {
            winChance = 95;
        }
        if (winChance <= 5)
        {
            winChance = 5;
        }
        display.text = rounded.ToString() + "%";
    }


    public void lvl3() //third level opponents have a score of 60-80
    {

        buttons.SetActive(false);

        oppscore = Random.Range(60f, 80f);
        winChance = 95 - (oppscore - score);
        if (winChance >= 95)
        {
            winChance = 95;
        }
        if (winChance <= 5)
        {
            winChance = 5;
        }
        display.text = rounded.ToString() + "%";
    }


    public void lvl4() //fourth level opponents have a score of 80-100
    {

        buttons.SetActive(false);

        oppscore = Random.Range(80f, 100f);
        winChance = 95 - (oppscore - score);
        if (winChance >= 95)
        {
            winChance = 95;
        }
        if (winChance <= 5)
        {
            winChance = 5;
        }

        display.text = rounded.ToString() + "%";
    }


    public void lvl5() //fifth level opponents have a score of 100-120
    {

        buttons.SetActive(false);

        oppscore = Random.Range(100f, 120f);
        winChance = 95 - (oppscore - score);
        if (winChance >= 95)
        {
            winChance = 95;
        }
        if (winChance <= 5)
        {
            winChance = 5;
        }
        display.text = rounded.ToString() + "%";
    }
}
