using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisintagrateObject : MonoBehaviour
{
    public float duration = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Disintagrate", duration);
    }

    void Disintagrate()
    {
        Destroy(gameObject);
    }
}
