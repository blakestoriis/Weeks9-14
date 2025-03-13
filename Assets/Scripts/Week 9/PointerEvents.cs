using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerEvents : MonoBehaviour
{

    public UnityEngine.UI.Image image;

    public Sprite donut;
    public Sprite salad;

    public float x;
    public float y;

    public float xLimit;
    public float yLimit;

    public GameObject spawner;

    public void MouseOver()
    {
        image.sprite = salad;
    }

    public void MouseNotOver()
    {
        image.sprite = donut;
    }

    public void OnClick()
    {
        Vector3 pos = transform.position;
        pos.x += x;
        

        if (pos.x == xLimit)
        {
            pos.x = -400;
            pos.y += y;
        }

            transform.position = pos;
    }

}

