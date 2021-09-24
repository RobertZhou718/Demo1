using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshairdistance : MonoBehaviour
{
    public GameObject crosshair;
    
    public RaycastHit line;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if (Physics.Raycast(ray, out line, 1000))//Emit a virtual ray in the middle of the screen(crosshair)
        {
            if (line.distance < 10)
            {
                crosshair.transform.localScale = new Vector3(5, 5 , 0.4f);//larger
             
            }
            else {
                crosshair.transform.localScale = new Vector3(5, 5, 1.5f);//recover
            }                
        }

    }
}

