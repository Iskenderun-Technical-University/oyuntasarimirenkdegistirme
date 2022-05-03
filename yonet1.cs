using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yonet1 : MonoBehaviour
{

    public TMPro.TextMeshProUGUI txtYuksekPuan;
    // Start is called before the first frame update
    void Start()
    {
        txtYuksekPuan.text = PlayerPrefs.GetInt("yuksekpuan").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        txtYuksekPuan.text = PlayerPrefs.GetInt("yuksekpuan").ToString();

    }
}
