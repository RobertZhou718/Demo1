using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypool : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemy;
    public static int amount = 10;
    public static int killedAmount = 0;

    void Start()
    {
        for (int i = 0; i < amount; i++)//Randomly generate 10 enemies in range(70,2,70)
        {
            GameObject obj = (GameObject)Instantiate(enemy);
            int x = Random.Range(0, 70);
            int z = Random.Range(0, 70);

            obj.transform.position = new Vector3(x, 2, z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (amount < 10)//destroy one, generate one
        {
            GameObject obj = (GameObject)Instantiate(enemy);
            int x = Random.Range(0, 70);
            int z = Random.Range(0, 70);

            obj.transform.position = new Vector3(x, 2, z);
            amount += 1;
        }
    }
}
