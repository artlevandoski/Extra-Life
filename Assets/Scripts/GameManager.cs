using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //this creates a singleton, so that this is able to be referred to anywhere in the project

    //use GameManager.* to access this script

    public float coinsToCollect = 100;

    public float coinsCollected;

    public float eternalToCollect = 100;

    public float eternalCollected;

    public bool showExit = false;

    public bool showEternal = false;

    public GameObject ExitPortal;

    public GameObject EternalCoin;

           
    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if(coinsCollected == coinsToCollect)
            {
                showExit = true;
                showEternal = true;
            }

        if(showExit == true)
            {
                ExitPortal.SetActive(true);
            }
            
        if(showEternal == true)
            {
                EternalCoin.SetActive(true);
            }
            

    }

    

  
}
