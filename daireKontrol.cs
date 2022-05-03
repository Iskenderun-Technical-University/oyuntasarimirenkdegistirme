using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daireKontrol : MonoBehaviour
{
    public float donmeHiz=500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, donmeHiz * Time.deltaTime);
    }
}
