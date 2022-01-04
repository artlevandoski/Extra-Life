using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   //starts the game
   public void OnPlayButton()
   {
       SceneManager.LoadScene(0);
   }

   //quits the game when in executable form
   public void OnQuitButton()
   {
       Application.Quit();
   }
}
