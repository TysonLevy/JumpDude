using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != "Coins: " + Coins.totalCoins.ToString())
        {
            counterText.text = "Coins: " + Coins.totalCoins.ToString();
        }
        if (Coins.totalCoins == 5)
        {
            changeScene();
        }
    }

    void changeScene()
    {
        SceneManager.LoadScene(2);
    }
}