using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    float startTime = 60f;
    //public Text timer;
    float time = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( time < 0)
        {
            time = 1f;
            startTime -= 1;
        }
        time -= Time.deltaTime;
        if (startTime > -1)
        {

            GetComponent<Text>().text = "Time: " + startTime;
        }
         if (startTime == 0) {
            GetComponent<Text>().text = "TIME OUT!";
            //UnityEditor.EditorApplication.isPlaying = false;
            Time.timeScale = 0;
        } 
    }
}
