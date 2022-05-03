using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraKontrol : MonoBehaviour
{
    public Transform topunTransformu;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (topunTransformu.position.y >gameObject.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, topunTransformu.position.y, transform.position.z);
        }


    }
}
