using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveText : MonoBehaviour
{

    bool ObjToggl;
    public GameObject ObjectText;

    // Start is called before the first frame update
    void Start()
    {
        ObjToggl = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ObjectiveToggle() //toggles the objective
    {
        ObjToggl = !ObjToggl;
        ObjectText.SetActive(ObjToggl);
    }

    

}
