using UnityEngine;
public class CovidSpawner : MonoBehaviour {

    public GameObject covidPrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public GameObject cubeObject;
    public GameObject player;
    
    void Start () {
        //With InvokeRepeating() our spawnObjects are invoking according to the repeatRate.
        InvokeRepeating("SpawnObject", spawnTime, 0.2f);
	}
    
    public void SpawnObject() {

         /*SpawnObjects are instantiating according to the player's position. For x line, it takes our player's vectors.
         For y line, it takes cube's vector. Random.Range() provides randomly falling spawners. */

        Vector3 playerVector1 = player.transform.position;
        playerVector1.x -=5;

        Vector3 playerVector2 = player.transform.position;
        playerVector2.x +=100;

        Vector3 cubeVector = cubeObject.transform.position;
        cubeVector.y +=100;

        Instantiate(covidPrefab,new Vector3(Random.Range(playerVector1.x, playerVector2.x),cubeVector.y,Random.Range(995, 1007)),Quaternion.identity);
        if(stopSpawning) {
            CancelInvoke("SpawnObject");
        }
    }
}
