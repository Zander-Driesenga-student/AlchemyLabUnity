using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeObjects : MonoBehaviour
{
    public GameObject objects;
    public int amountOfObjects;
    public bool activate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!activate)
        {
            for (int i = 0; i < amountOfObjects; i++)
            {
                Instantiate(objects, transform.position, Quaternion.identity);
            }
        }
        activate = false;
    }

}
