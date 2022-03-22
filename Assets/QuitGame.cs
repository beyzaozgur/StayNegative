using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
  public void Quit()
  {
    // Application.Quit();  -----> this is for built version of the game 
    UnityEditor.EditorApplication.isPlaying = false; // this is for exiting play mode.
    Debug.Log("Quit!");
  }
}
