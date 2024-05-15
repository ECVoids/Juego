using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 5f;
   
   void Awake(){
    rb = GetComponent<Rigidbody>();
    
   }
    // Update is called once per frame
    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(MoveHorizontal*speed, rb.velocity.y, MoveVertical*speed);
        rb.velocity = Movement;
        rb.transform.LookAt(rb.transform.position+Movement);
    }   

}
