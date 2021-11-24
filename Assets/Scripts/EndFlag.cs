using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public string nextSceneName;
    public bool lastLevel;

    private void OnTriggerEnter(Collider other)
    
    {
        if(other.CompareTag("Player"))
        {
            if(lastLevel == true) //loads the ending scene
            {
               SceneManager.LoadScene(2); //change this as game development progresses
            }
            else
            {
                SceneManager.LoadScene(nextSceneName); //loads the next level in the game
            }
        }

    }
 

  
}
