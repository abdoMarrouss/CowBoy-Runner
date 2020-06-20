using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class TileManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] tilePrefabs;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 10f;
    private int amnTileOnScreen = 7;
    private float safeZone = 15f;
    private List<GameObject> activeTiles;


    void Start()
    {
        activeTiles = new List<GameObject> ();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i=0; i<amnTileOnScreen; i++){
            SpawwnTiles();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z - safeZone > spawnZ -amnTileOnScreen *tileLength){
            SpawwnTiles();
            DeleteTile();
        }
        
    }
    private void SpawwnTiles(int prefabsIndex = -1){
        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject; 
        go.transform.SetParent (transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);

    }
    private void DeleteTile() {
        Destroy(activeTiles [0]);
        activeTiles.RemoveAt(0);
    }
}
