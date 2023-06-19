using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    Rigidbody _rb;
    // Health Manager

    HealthManager _healthManager;
    GameManager _gameManager;
    Animation _anim;
    // Position
    [SerializeField] private float leftPosition =8.0f;
    [SerializeField] private float rightPosition =8.0f;
    [SerializeField] private float thrust =30.0f;
    [SerializeField] private int leftIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animation>();
        _healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
        _rb = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update(){
        _rb.velocity = transform.forward*thrust;
        if (Input.GetKeyDown(KeyCode.A) && leftIndex<1 && _gameManager.isGameRunning){
            leftIndex+=1;
            transform.position+= Vector3.left*leftPosition;
        }
        if (Input.GetKeyDown(KeyCode.D) && leftIndex>-1 && _gameManager.isGameRunning){
            leftIndex-=1;
            transform.position+= Vector3.left*-1*rightPosition;
        }

    if (_healthManager.health==0)
    {
        thrust = 0.0f;
        _anim.Play("Dizzy");
    }

  

    }
    // Update is called once per frame
    
    
    void FixedUpdate()
    {
        
        thrust = thrust+ GameObject.Find("GameManager").GetComponent<GameManager>().points/10000.0f*Time.deltaTime;
        // Move character forward constant
        _rb.AddForce(transform.forward*thrust);
    }
}
