using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //this creates a singleton, so that this is able to be referred to anywhere in the project

    //use GameManager.* to access this script

    public float coinsToCollect = 100;

    public int eternalCoinsToCollect = 100;

    public float coinsCollected;

    public bool showEternalCoins = false;

    public bool showExit = false;

    public GameObject EndFlag;
    
    void Awake()
    {
        instance = this;
    }

     //updates the car positions
    void Update()
    {
        if(coinsCollected == coinsToCollect)
            showEternalCoins = true;

        if(coinsCollected == coinsToCollect)
            EndFlag.SetActive(true);    

    }

    

  
}
