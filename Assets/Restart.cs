using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Restarts the game from the "Start" scene.
   
    public static void LoadGame()
    {
        SceneManager.LoadScene("Start");
    }
}
