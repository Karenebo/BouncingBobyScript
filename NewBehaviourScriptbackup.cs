using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public float speed = 3;

    public float force = 350;

    void Start ()
    {
        // Float towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void Update()
    {
        // Float
        if(Input.GetKeyDown(KeyCode.Space))
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force); 
        
    }

    
}
