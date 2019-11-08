using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private RigidBody2D _rigidBody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody2D = GetComponent<RigidBody2D>();             
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody2D.AddForce(Vector2.up * jumpHeight);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
    }

    // Update is called once per frame
    /* 
    void Update()
    {
        var jumpSpeed: float = 8;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity += jumpSpeed * Vector3.up;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        

        /* 
            // We are grounded, so recalculate
            // move direction directly from axes

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;

        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        */
    
    /* }
    */
}
