using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu: MonoBehaviour
{
 
 public void OnReturnMenu()

 {
     PlayerScore.score = 0;//resets player score prior to main menu return
     SceneManager.LoadScene(0);//returns the player to the main menu
 }

}
