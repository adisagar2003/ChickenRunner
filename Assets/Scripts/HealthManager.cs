using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int health=3;

    GameManager _gameManager;
    // Update is called once per frame
    void Start(){
        health =3;
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void decreaseHealth()
    {
        health-=1;
    }

    public void increaseHealth(){
        health+=1;
    }


    void Update(){
        if (health<1){
            _gameManager.isGameRunning = false;
        }
    }




}
