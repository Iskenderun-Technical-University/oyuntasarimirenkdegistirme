using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yonetici : MonoBehaviour
{
    public Text skoryazisi;
    public static int skor = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skoryazisi.text = "SKOR: " + skor.ToString();
        if (skor > PlayerPrefs.GetInt("yuksekpuan"))
        {
            PlayerPrefs.SetInt("yuksekpuan", skor);
        }
    }
}
