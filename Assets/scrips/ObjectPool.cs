using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool ShareInstance;
    public List<GameObject> pooleObjects;
    public GameObject ObjectToPool;
    public int amountToPool;

    private void Awake() {

        ShareInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        pooleObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++) {
            GameObject obj = (GameObject)Instantiate(ObjectToPool);
            obj.SetActive(false);
            pooleObjects.Add(obj);
         }
    }

    public GameObject GetPooleObject() {
        for (int i = 0; i < pooleObjects.Count; i++)
            if (!pooleObjects[i].activeInHierarchy)
                return pooleObjects[i];
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
