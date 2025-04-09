using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class homunculus : MonoBehaviour
{
    public Sprite normal;
    public Sprite squish;

    public Image sprite;

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
        sprite.sprite = squish;
    }

    public void hoverOff()
    {
        sprite.sprite = normal;
    }

}
