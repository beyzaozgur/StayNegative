using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCovid : MonoBehaviour
{
 
      public GameObject covidPrefab;
      public bool stopSpawning = false;
      public Transform infectedPerson;
      public float covidForceForward;
      public float covidForceUp;
      
      //With InvokeRepeating() our spawnObjects are invoking according to the repeatRate.
      void Start ()
      {
          InvokeRepeating("SpawnObject", 1.0f, 2.0f);
      }
  
      /*GameObject covid is instances of covidPrefab and it instantiates according to player's position and rotation.
       It calls the component of rigidbody and then adding force to throw its prefabs. In AddForce(),
       we are choosing the direction and then multiply it with the foce that we write. ForceMode.Impulse is
       adding an instance force to rigidbody by using mass.*/
      public void SpawnObject() {
          GameObject covid=Instantiate(covidPrefab,infectedPerson.position,infectedPerson.rotation);
          Rigidbody rb = covid.GetComponent<Rigidbody>();
          rb.AddForce(infectedPerson.forward*covidForceForward,ForceMode.Impulse);
          rb.AddForce(infectedPerson.up*covidForceUp,ForceMode.Impulse);
  
          if(stopSpawning) {
              CancelInvoke("SpawnObject");
          }
          
      }
  }

