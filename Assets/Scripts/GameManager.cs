using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //this creates a singleton, so that this is able to be referred to anywhere in the project

    //use GameManager.* to access this script

    public int coinsToCollect = 100;

    public bool showEternalCoins = false;

    public bool showExit = false;
    
    void Awake()
    {
        instance = this;
    }

  
}
