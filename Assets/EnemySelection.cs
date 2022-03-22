using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySelection : MonoBehaviour
{
    public GameObject[] EnemyList; // Creating an empty list to assign on the unity
    private int Index;

   
    private void Start()
    {
       
        Index = PlayerPrefs.GetInt("SelectedEnemy");
    
         // All enemies is set to False
        foreach (GameObject go in EnemyList)
        {
            go.SetActive(false);
        }

         // The chosen enemy is set to true
        if (EnemyList[Index])
        {
            EnemyList[Index].SetActive(true);
        }
        
        
    }

    // if player selects Ethane Enemy as enemy that follows and throws ball 

    public void playWithEnemyEthane()
    {
        Index = 0;
        PlayerPrefs.SetInt("SelectedEnemy",Index);
        
        SceneManager.LoadScene("Level2");
      
        
    }

     // if player selects infected person as enemy that follows and throws ball
    public void playWithInfectedPerson()
    {
        Index = 1;
        PlayerPrefs.SetInt("SelectedEnemy",Index);
        
        SceneManager.LoadScene("Level2");
        
    }
}
