using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DieIfTouched : MonoBehaviour
{
   // If the tag is Player, loads the GameoVerScene.
        void OnCollisionEnter(Collision c)
        {
            
            if (c.gameObject.tag == "Player" )
            {
                Destroy(c.gameObject);
                SceneManager.LoadScene("GameOverScene");
            }

          
        }

    
}