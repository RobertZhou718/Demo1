using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public AudioSource audioSource;
    float time = 0f;
   

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (time > 0.05f)
            {
                GameObject newBullet = ObjectPool.ShareInstance.GetPooleObject();
                if (newBullet)
                {
                    newBullet.transform.position = transform.position + transform.up;
                    newBullet.GetComponent<Rigidbody>().velocity = transform.up * 300;
                    newBullet.SetActive(true);
                    audioSource.Play();
                    time = 0f;
                }
            }
            time += Time.deltaTime; 
        }
    }
};
