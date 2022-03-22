using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;
public class FollowTheGameObject : MonoBehaviour
{


    private GameObject player;
        private NavMeshAgent navmesh;
        
        void Start()
        {
            // Player object is setted to active Player on the scene.
            player = GameObject.FindWithTag("Player");
           
            navmesh = GetComponent<NavMeshAgent>();
        }
        
         // Set infected person's destination to player's position.
        void Update()
        {
            if (player != null) {
                navmesh.destination = player.transform.position;
            }
                
           
            
        }
}
