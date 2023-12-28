using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controller : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            animator.SetBool("running",true);
        } else if(!Input.GetKey("w")){
            animator.SetBool("running",false);
        
        }
        if(Input.GetKey("c")){
            animator.SetBool("croching",true);
            animator.SetBool("running",false); 
        } else if(!Input.GetKey("c")) {
            animator.SetBool("croching", false);
        }
        if(Input.GetKey("s")){
            animator.SetBool("Moonwalk",true);
            animator.SetBool("running",false);
            Debug.Log("Back Serega loh");
        } else if(!Input.GetKey("s")) {
            animator.SetBool("Moonwalk", false);
            
        }
        
    }
}
