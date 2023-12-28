using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dvizenie_Zizn : MonoBehaviour
{
    [Header("Movement")]
    private float movespeed = 5;
    public float wokspeed;
    public float ranspeed;
    public float zemlyatianet;
    public Transform Orientation;
    Vector3 move_one_direction;
    bool grounded;

    

    float horizontal_input;
    float vertical_input;
    Rigidbody RB;
    public MoveSteak Steak;
    public enum MoveSteak
    {
        Beg, 
        Hotba,
        Butilka_Mode,
        Nihuia_ti_baklazan
    }

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ti_Cho_Sdelal();//Get_User_input;
        //stop player from yehahaha;
        if (grounded == true){
            RB.drag = zemlyatianet;
            
        } else {
            RB.drag = 0;
        }    

    }
    void FixedUpdate(){
        Move_Player();
    }
    void Move_Player(){
        move_one_direction = Orientation.forward * vertical_input + Orientation.right * horizontal_input;
        RB.AddForce(move_one_direction * movespeed * 10,ForceMode.Force);
    }
    void Ti_Cho_Sdelal(){
        //Where da fuck you looking fool
        horizontal_input = Input.GetAxisRaw("Horizontal");
        vertical_input = Input.GetAxisRaw("Vertical");
        //croch
        if(Input.GetKey("c")){
            
        }
        if(Input.GetKeyUp("c")){

        }
    }
    //Check if palyer is on the gorund
    void OnCollisionStay(Collision Object){
        if (Object.gameObject.tag == "Ground"){
            grounded = true;
        }
    }
    void OnCollisionExit(Collision Object){
        if (Object.gameObject.tag == "Ground"){
            grounded = false;
        }
    }


}
