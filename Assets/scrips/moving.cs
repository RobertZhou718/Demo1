using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    float direction;
    float timer = 5f;
   // float directionX, directionY;
    float moveSpeed = 5f;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.forward * Time.deltaTime);

        if (timer < 0)
        {
           // directionX = Random.Range(0, 50);
            //directionY = Random.Range(0, 50);
            direction = Random.Range(0, 360f);
            transform.rotation = Quaternion.Euler(0, direction, 0);//rotating randomly around the Y-axis
            timer = 5f;
            
        }
        timer -= Time.deltaTime;
        transform.Translate(transform.forward * Time.deltaTime * moveSpeed);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "enemy")
        {
         

            Destroy(this.gameObject);
            
            enemypool.killedAmount += 1;
            enemypool.amount -= 1;
        }

    }
}
