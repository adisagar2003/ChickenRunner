using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int health;
    private HealthManager _healthManager;
    [SerializeField] private TextMeshProUGUI healthUI;
    
    void Start(){
        _healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
    }

    void Update(){
        
    }   
}
