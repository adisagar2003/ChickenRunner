using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickAnim : MonoBehaviour
{
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Other){
        if (Other.tag=="Player"){

            _anim.SetTrigger("Jump");
        }
    }
}
