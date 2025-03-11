using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleAnimation : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t = 0;

    public float height;
    

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Vector3 pos = transform.position;
        pos.y = height;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

        float ScreenH = Screen.height - height;

        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }

        float baseHeight = 2f;
        UnityEngine.Vector3 pos = transform.position;
        //pos.y = cameraTop - curve.Evaluate(t) * 30;
        pos.y = baseHeight * curve.Evaluate(t) * 30 + ScreenH;

        transform.position = pos;


    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
