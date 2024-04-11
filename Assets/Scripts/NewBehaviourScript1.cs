using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        //animator.SetFloat("Speed", Mathf.Abs(transform.Translate(0.05f,0f,0f)));
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0.08f,0f,0f);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-0.08f,0f,0f);
        } 
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,0.08f,0.08f);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0,-0.08f,-0.08f);
        }
    }
}
