using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public void oyunaBasla()
    {

        SceneManager.LoadScene("Scenes/oyun");
        Time.timeScale = 1.0f;
    }
}
