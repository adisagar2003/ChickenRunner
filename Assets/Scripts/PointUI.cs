using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointUI : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI UIPoints;
    private float points;

    void Start(){
        UIPoints = GetComponent<TextMeshProUGUI>();
    }
    void Update(){
        points = GameObject.Find("GameManager").GetComponent<GameManager>().points;
        UIPoints.text = "Score: "+points;
        Debug.Log(points);
    }

}
