using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoctorPassLevel : MonoBehaviour
{

   // When the doctor touches the vaccine, it loads EnemySelection scene.
   void OnControllerColliderHit(ControllerColliderHit hit)
   {
      if (hit.gameObject.tag == "Vaccine")
      {
         SceneManager.LoadScene("EnemySelection");
      }
   }
}
