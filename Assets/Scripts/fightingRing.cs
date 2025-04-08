using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

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
    float randomroll; //random roll that determines the win/lose condition

    int level; //level of the opponent

    public TextMeshProUGUI display; //displays the win chance
    public GameObject buttons;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = stats.health/5 + stats.damage * 5; //score is calculated by adding a fifth of the players health, combined with 5x theplayers strength scores
         rounded = Mathf.RoundToInt(winChance); //rounds winchance to an int
        display.text = rounded.ToString() + "%";

        if (stats.displayHealth <= 0)
        {
            leaveFight();
        }

    }

    public void ClickFight() //when the fight button is pressd it hides all the currently active UI and shows the new pages UI
    {
        feed.SetActive(false);
        statbox.SetActive(false);
        buttons.SetActive(true);
        leave.SetActive(true);
    }

    public GameObject leave; // leave button to head back to main menu
    public void leaveFight() //turns off fight page UI and turns on main page UI
    {
        feed.SetActive(true);
        statbox.SetActive(true);
        fightbox.SetActive(false);
        buttons.SetActive(false);
        leave.SetActive(false);
        text.SetActive(false);
    }

    public void lvl1 () //first level opponents have a score of 20-40
    {
        level = 1;
        buttons.SetActive(false);
        fightbox.SetActive(true) ;

        oppscore = Random.Range(20f, 40f); //sets the random level score
        winChance = 95 -(oppscore - score); //win chance is the difference between scores. the closer the scores teh higher teh chance of winning
        if (winChance >= 95) // sets parameters so the chance is always at a max of 95% and a minumin 5%
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
        level = 2;
        buttons.SetActive(false);
        fightbox.SetActive(true);

        oppscore = Random.Range(40f, 60f);//sets the random level score
        winChance = 95 - (oppscore - score);//win chance is the difference between scores. the closer the scores teh higher teh chance of winning
        if (winChance >= 95)// sets parameters so the chance is always at a max of 95 % and a minumin 5 %
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
        level = 3;
        buttons.SetActive(false);
        fightbox.SetActive(true);

        oppscore = Random.Range(60f, 80f); //sets the random level score
        winChance = 95 - (oppscore - score);//win chance is the difference between scores. the closer the scores teh higher teh chance of winning
        if (winChance >= 95)// sets parameters so the chance is always at a max of 95 % and a minumin 5 %
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
        level = 4;
        buttons.SetActive(false);
        fightbox.SetActive(true);

        oppscore = Random.Range(80f, 100f); //sets the random level score
        winChance = 95 - (oppscore - score);//win chance is the difference between scores. the closer the scores teh higher teh chance of winning
        if (winChance >= 95)// sets parameters so the chance is always at a max of 95 % and a minumin 5 %
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
        level = 5;
        buttons.SetActive(false);
        fightbox.SetActive(true);

        oppscore = Random.Range(100f, 120f);//sets the random level score
        winChance = 95 - (oppscore - score);//win chance is the difference between scores. the closer the scores teh higher teh chance of winning
        if (winChance >= 95)// sets parameters so the chance is always at a max of 95 % and a minumin 5 %
        {
            winChance = 95;
        }
        if (winChance <= 5)
        {
            winChance = 5;
        }
        display.text = rounded.ToString() + "%";
    }

    public TextMeshProUGUI outcome; //displays winner or loser
    public GameObject text; //turns on and off the outcome
    public GameObject fightbox; //the box that displays the fight button

    public Clips clip; //accessing the clips script to increase clips

    int win;//tracks winning streak

    public void fight() // determines the winner / loser of the game
    {
        randomroll = Random.Range(1f, 100f);
        if (randomroll >= rounded) //if player lost (higher then percent)
        {
            stats.displayHealth -= level * 5; //lose level x 5 health
            text.SetActive(true); //shows text
            win = 0; //resets loose streak
            outcome.text = "Your homunculus lost, heal up and try again";
            fightbox.SetActive(false); //hides fightbox too you cant fight the same one again

        }

        if (randomroll <= rounded) //if player won (lower then percent)
        {
            clip.clips += (level * 10) * win; // you gain the level x 10 clips, along with times the win multiplier
            win += 1; //adds to win streak
            text.SetActive(true); //shows text
            outcome.text = "Your homunculus won! ";
            fightbox.SetActive(false); //hides fightbox too you cant fight the same one again
        }

    }
}
