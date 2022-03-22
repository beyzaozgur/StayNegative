using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoctorDie : MonoBehaviour
{
     // If the tag is Fire or Water, GameOver scene is loaded.
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Fire" || hit.gameObject.tag == "Water")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
