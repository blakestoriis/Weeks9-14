using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitchII : MonoBehaviour
{
    public GameObject prefab;

    public Canvas canvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mouse = Input.mousePosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newPrefab = Instantiate(prefab, mouse, Quaternion.identity);
            newPrefab.transform.SetParent(canvas.transform, false);
        }
    }
}
