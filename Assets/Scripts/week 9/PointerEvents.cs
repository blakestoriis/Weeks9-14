using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointerEvents : MonoBehaviour
{
    public float xPlus; //how much the x increases on click
    public float yPlus; //how much the y increases on click

    public GameObject image; //donut/salad prefab
    public UnityEngine.UI.Image sprite; //donut sprite

    public Sprite donut;
    public Sprite salad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hoverOver()
    {
        sprite.sprite = salad;
    }

    public void hoverOff()
    {
        sprite.sprite = donut;
    }

    public void SpawnNew()
    {
        Instantiate(image);
    }
}
