using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tiles;
    private GameObject player;
    private float tileLength = 48.82f;
    private int randomIndex;
    [SerializeField] private float spawnZ=42.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCleanTile();
        SpawnCleanTile();
        SpawnCleanTile();
             SpawnTile();
          SpawnTile();
            SpawnTile();
            SpawnTile();
          SpawnTile();
            SpawnTile();
             SpawnTile();
          SpawnTile();
            SpawnTile();


        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile(){
        GameObject  spawnedTile;
        spawnedTile = Instantiate(tiles[RandomPrefabIndex()]) as GameObject;
        spawnedTile.transform.SetParent(transform);
        spawnedTile.transform.position= Vector3.forward*spawnZ;
        spawnedTile.transform.Rotate(0,90,0); 
        spawnZ+=tileLength;
    }


    public void SpawnCleanTile(){
        GameObject  spawnedTile;
        spawnedTile = Instantiate(tiles[0]) as GameObject;
        spawnedTile.transform.SetParent(transform);
        spawnedTile.transform.position= Vector3.forward*spawnZ;
        spawnedTile.transform.Rotate(0,90,0); 
        spawnZ+=tileLength;
    }


    private int RandomPrefabIndex(){
      randomIndex = Random.Range(0,tiles.Length);
      return randomIndex;
    }
}
