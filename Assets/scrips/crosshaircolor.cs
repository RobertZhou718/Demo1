using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshaircolor : MonoBehaviour
{
    public GameObject crosshair1;
    public GameObject crosshair2;

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
            if (line.collider.transform.tag == "enemy")//Conduct collision detection
            {
                crosshair1.GetComponent<Renderer>().material.color = Color.red;
                crosshair2.GetComponent<Renderer>().material.color = Color.red;

            }
            else
            {
                crosshair1.GetComponent<Renderer>().material.color = Color.green;
                crosshair2.GetComponent<Renderer>().material.color = Color.green;

            }
        }
    }
}
