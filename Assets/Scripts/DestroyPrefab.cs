using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    private TileManager _tileManager;
    // Start is called before the first frame update
    void Start()
    {  
       _tileManager = GameObject.Find("TileManager").GetComponent<TileManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other){

        if (other.tag=="Player") {
            Destroy(gameObject);
            Debug.Log("Destroy GameObject");
            _tileManager.SpawnTile();

        }
    }
}
