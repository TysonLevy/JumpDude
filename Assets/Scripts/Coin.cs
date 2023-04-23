using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //Keep track of total picked coins (Since the value is static, it can be accessed at "SC_2DCoin.totalCoins" from any script)
    public static int totalCoins = 0;
    public AudioClip coin;
    AudioSource aScorce;
    GameObject obj;

    void Start()
    {
        obj = GameObject.Find("AudioObject");
        if (obj != null)
            aScorce = obj.GetComponent<AudioSource>();
    }
    
    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }



    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
            totalCoins++;
            //Test: Print total number of coins
            Debug.Log("You currently have " + Coins.totalCoins + " Coins.");
            //Destroy coin
            aScorce.clip = coin;
            aScorce.Play();
            Destroy(gameObject);
        }
    }
}