using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject[] obstaclePrefabs;
    private Vector3 spawnObstaclePosition;
    

    // Update is called once per frame
    void Update()
    {
        float distanceToHoriszon = Vector3.Distance(player.gameObject.transform.position, spawnObstaclePosition);
        if(distanceToHoriszon < 120){
            SpawnObstacles();
        }
    }
    void SpawnObstacles(){
        spawnObstaclePosition = new Vector3(0,0 , spawnObstaclePosition.z + 22);
        Instantiate (obstaclePrefabs[(Random.Range(0, obstaclePrefabs.Length))], spawnObstaclePosition, Quaternion.identity);
    }
}
