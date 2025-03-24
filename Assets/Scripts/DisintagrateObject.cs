using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisintagrateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Disintagrate", 5);
    }

    void Disintagrate()
    {
        Destroy(gameObject);
    }
}
