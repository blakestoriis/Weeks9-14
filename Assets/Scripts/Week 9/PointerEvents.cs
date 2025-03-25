using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerEvents : MonoBehaviour
{

    public UnityEngine.UI.Image image;

    public Sprite donut;
    public Sprite salad;

    public float x;
    public float y;

    public float xLimit;
    public float yLimit;

    public Vector3 spawner;
    public GameObject prefab;

    public Canvas canvas;

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
        

        if (pos.x >= xLimit)
        {
            pos.x = 60;
            pos.y -= y;
        }

        spawner = new Vector3(pos.x-450, pos.y-240, pos.z);
            transform.position = pos;

        GameObject newPrefab = Instantiate(prefab,spawner, Quaternion.identity);
        newPrefab.transform.SetParent(canvas.transform, false);

    }

}

