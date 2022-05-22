using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public bool isGrounded;
    public Rigidbody rb;
    private bool isLive = true;
    private float jump = 2.7f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimationControl(); 
    }

    void AnimationControl(){
        if(!isLive){
            return;
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            isGrounded = false;
            rb.velocity = new Vector3(0.0f, jump, 0.0f);
        } else {
            
        }
    }

    void FixedUpdate() 
    {
        if(!isLive){
            return;
        }
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(transform.position + m_Input * Time.deltaTime * speed);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

}
