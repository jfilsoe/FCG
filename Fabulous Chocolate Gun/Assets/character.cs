using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 100;

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rigidBody = gameObject.GetComponent<Rigidbody2D>();

        float translation = Input.GetAxis("Horizontal") * speed;

        Vector3 position = this.transform.position;
        position.x += translation;
        this.transform.position = position;

        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            Collider2D[] results = new Collider2D[1];
            ContactFilter2D cf = new ContactFilter2D();
            if (rigidBody.OverlapCollider(cf, results) > 0)
            {
                rigidBody.AddForce(new Vector3(0, 300, 0));
            }
        }
    }
}
