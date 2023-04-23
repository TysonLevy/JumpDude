using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeup : MonoBehaviour
{

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countUp;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countUp ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;


        if(hasLimit && ((countUp && currentTime <= timerLimit || (!countUp && currentTime >= timerLimit))))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }

        SetTimerText();
    }

    private void SetTimerText()
    {
        PlayerPrefs.SetString("time", currentTime.ToString("0.0"));
        timerText.text = "Time: " + PlayerPrefs.GetString("time");
    }
}
