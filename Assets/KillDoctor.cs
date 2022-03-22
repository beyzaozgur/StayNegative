using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillDoctor : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(collider.gameObject);
            SceneManager.LoadScene("GameOverSceneInfected");
        }
    }
    
 
}
