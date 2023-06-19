using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager _gameManager;
    private float points;
    void Start(){
        points = GameObject.Find("GameManager").GetComponent<GameManager>().points;
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
   public void CountPoints(){
    Debug.Log("I can do it");
    if (_gameManager.isGameRunning) {
        points+=1;
        GameObject.Find("GameManager").GetComponent<GameManager>().points = points;
    }
   }

   void FixedUpdate(){
    CountPoints();
   }
}
