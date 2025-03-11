using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AppartmentDoor : MonoBehaviour
{

    public SpriteRenderer colliderSr;
    public SpriteRenderer objectSr;
    public Transform plrTrans;

    public bool interactable;
    bool Intro = true;


    public Sprite closed;
    public Sprite open;

    public GameObject Jelly;
    public PlayerController playerController;
    public JellyBaby baby;

    public TextMeshProUGUI Dialogue;
    public GameObject dialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if (interactable == true && Input.GetKeyDown(KeyCode.E) && Intro == true)
        {
            StartCoroutine(JellyIntro());
            //objectSr.sprite = open;
            playerController.enabled = false;
            Jelly.SetActive(true);


        }
    }

    public IEnumerator JellyIntro()
    {
        Jelly.SetActive(true);
        baby.enabled = false;
        
        yield return new WaitForSeconds(2f);
        dialogueBox.SetActive(true);

        Dialogue.text = "Trixie: uh hey...";
        yield return new WaitForSeconds(3f);

        Dialogue.text = "are you uh- are you Jelly?";
        yield return new WaitForSeconds(3f);

        Dialogue.text = "Jelly: %^%*@)*&@$#@&*)_@*&@%%*)@)";
        yield return new WaitForSeconds(3f);

        Dialogue.text = "Trixie: uhm...";
        yield return new WaitForSeconds(3f);

        Dialogue.text = "Jelly: *^&&^%#@%^^@&&*!@(";
        yield return new WaitForSeconds(3f);

        dialogueBox.SetActive(false);
        yield return new WaitForSeconds(3f);

        dialogueBox.SetActive(true);

        Dialogue.text = "Sorry about that. Yes, I'm Jelly, you must be Trixie?";
        yield return new WaitForSeconds(3f);

        Dialogue.text = "Trixie: Yup, Here, come in...";
        yield return new WaitForSeconds(3f);

        Dialogue.text = "Make yourself at home, your room is the one on the right";
        yield return new WaitForSeconds(3f);

        baby.enabled = true;
        dialogueBox.SetActive(false);
        playerController.enabled = true;

    }

}
