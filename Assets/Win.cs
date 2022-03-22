using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
       // Does the other collider have the tag "Player"?
        if (c.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Win");
        }
    }

    private void OnTriggerEnter( Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Win");
        }
    }
}
