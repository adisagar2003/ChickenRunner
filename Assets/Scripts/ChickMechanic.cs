using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class ChickMechanic : MonoBehaviour
{
    CinemachineImpulseSource impulse;
    GameManager gameManager;
    HealthManager HealthManager;
    // Start is called before the first frame update
    void Start()
    {
        impulse = transform.GetComponent<CinemachineImpulseSource>();
        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        HealthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
        if (other.tag=="Player") {
            Debug.Log("Collided, should be stopped.");
            HealthManager.decreaseHealth();
            ShakeCinemachineCamera();
            
            }
    }
    void ShakeCinemachineCamera(){

        impulse.GenerateImpulse(10.0f);
    }



}
