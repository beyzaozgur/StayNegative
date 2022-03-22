using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public HealthBar healthBar;
    public int maxHealth = 3;
    public int currentHealth;

    //Starting the game with the max health
    void Start() 
    {
        currentHealth = maxHealth;
       
    }

    //Decreasing the current health by damage(in our game it is 1) and then setting it
    void TakeDamage(int damage)
    {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);   
    }

    //When current health is 0, destroy the player and load the GameOverScene

    void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverSceneInfected");
        }
    }

    //Increase current health by 1 with disinfectant 
   void GainHealth(int disinfectant)
    {
        currentHealth += disinfectant;
        //Set healthBar and current health if it is under 6 (limitation)
        if (currentHealth <6)
        {
            healthBar.SetHealth(currentHealth);
           
            maxHealth = currentHealth;
                
            healthBar.SetMaxHealth(maxHealth);
                
        }
    }

     void OnCollisionEnter(Collision c)
      { 
        
           //If the player touches the object that has "covid" tag, call TakeDamage method
              if (c.gameObject.tag == "Covid")
              {
                  
                      c.gameObject.transform.Translate(0, 0, 5);
                      TakeDamage(1);

              }
               //If the player touches the object that has "Disinfectant" tag, call GainHealth method

              if (c.gameObject.tag == "Disinfectant")
              {
                  c.gameObject.transform.Translate(0, 0, 15);
                  GainHealth(1);


              }
          
      }
            // This is for "Doctor" since it has CharacterController
   
     void OnControllerColliderHit(ControllerColliderHit hit)
     {
         if (hit.gameObject.tag == "Covid")
         {
                  
             hit.gameObject.transform.Translate(0, 0, 5);
             TakeDamage(1);

         }

         if (hit.gameObject.tag == "Disinfectant")
         {
             hit.gameObject.transform.Translate(0, 0, 15);
             GainHealth(1);


         }
     }
}