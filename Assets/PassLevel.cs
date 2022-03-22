using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// modified
public class PassLevel : MonoBehaviour
{
   
   void OnCollisionEnter(Collision c)
   {
       //If the gameObject that touches the vaccine has "Player" tag, load EnemySelection scene.
      if (c.gameObject.tag == "Player")
      {
         SceneManager.LoadScene("EnemySelection");
         
      }
   }
  
   
}
