using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        timeText.text = "Time Taken: " + PlayerPrefs.GetString("time") + "s";
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
