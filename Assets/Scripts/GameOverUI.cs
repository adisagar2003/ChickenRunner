using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject _ui;
    HealthManager _healthManager;
    // Start is called before the first frame update
    void Start()
    {
        _healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_healthManager.health<1){
            _ui.SetActive(true);
        }
    }
}
