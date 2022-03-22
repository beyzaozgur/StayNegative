using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterSelection : MonoBehaviour
{
   public GameObject[] CharacterList; // Creating an empty list to assign on the unity
   private int Index;
  

   private void Start()
    {

        
        Index = PlayerPrefs.GetInt("Selected"); 

        // All characters is set to False    
        foreach (GameObject go in CharacterList)
        { 
            go.SetActive(false);
        }
           
     
         // The chosen character is set to true    
        if (CharacterList[Index])
        {
            CharacterList[Index].SetActive(true);
        }
        
               
            
    }
    // if player selects Ethane as character that follows and throws ball 
    
    private void playWithEthane()
    {
    
        Index =0;
        
        PlayerPrefs.SetInt("Selected",Index);
        
        SceneManager.LoadScene("Level1");
        
      
        
    }
    // if player selects doctor as character that follows and throws ball 
    private void playWithDoctor()
    {
        Index =1;
     
        PlayerPrefs.SetInt("Selected",Index); 
        
        SceneManager.LoadScene("Level1");
      
       
    }
    
    

   

   

 

    
    
}
;
