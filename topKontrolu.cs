using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class topKontrolu : MonoBehaviour
{
    public float ziplamaKuvveti = 15f;
    string mevcutRenk;
    public Color topunRengi;
    public Text skoryazisi;
    public static int skor = 0;
    public GameObject[] daireler;
    public GameObject renkTekeri;
    void Start()
    {
        skoryazisi.text = skor.ToString();
        topunRengi = GetComponent<SpriteRenderer>().color;
        randomRenk();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ziplamaKuvveti;        }

        //skoryazisi.text = "SKOR: " + skor.ToString();
        //if (skor > PlayerPrefs.GetInt("yuksekpuan"))
        //{
        //    PlayerPrefs.SetInt("yuksekpuan", skor);
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if(collision.tag == "skorArttir")
        {
            skor += 50;
            skoryazisi.text = skor.ToString();
            int rastCember = Random.Range(0, 2);
            Instantiate(daireler[rastCember], new Vector3(transform.position.x, transform.position.y + 12f, transform.position.z), Quaternion.identity);
            Instantiate(renkTekeri, new Vector3(transform.position.x, transform.position.y + 12f, transform.position.z), Quaternion.identity);

        }
        if (collision.tag == "renkTekeri")
        {
            randomRenk();
            Destroy(collision.gameObject);
           
            return;
        }

        if (collision.tag != mevcutRenk && collision.tag != "skorArttir")
        {
            skor = 0;
            skoryazisi.text = skor.ToString();
            //SceneManager.LoadScene(0);
            Debug.Log("Oyun bitti..");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // Destroy(gameObject);
            Debug.Log("Oyun tekrar baþladý");

        }

    }
    void randomRenk()
    {
        int randomNumber = Random.Range(0, 4);

        switch (randomNumber)
        {
            case 0 : mevcutRenk = "mavi";
                topunRengi = Color.cyan;
                break;
            case 1 :mevcutRenk = "sari";
                topunRengi = Color.yellow;
                break;
            case 2: mevcutRenk = "kirmizi";
                topunRengi = Color.red;
                break;
            case 3: mevcutRenk = "mor";
                topunRengi = Color.magenta;
                break;
        }
        GetComponent<SpriteRenderer>().color = topunRengi;
    }
}
