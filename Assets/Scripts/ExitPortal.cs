using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitPortal : MonoBehaviour
{

    public string nextSceneName;
    public bool lastLevel;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    
    {
        if(other.CompareTag("Player"))
        {
            if(lastLevel == true) //loads the ending scene
            {
               SceneManager.LoadScene(1); //change this as game development progresses
            }
            else
            {
                SceneManager.LoadScene(nextSceneName); //loads the next level in the game
            }
        }
    }
      
}