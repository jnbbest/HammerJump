using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public static ControlScript instance;
    public Rigidbody rb;
    public float force;
    public float speed;
    private void Awake()//
    {
        instance = this;
    }
    void Start()
    {
        
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //transform.position += new Vector3(0, 0, -5);
            rb.AddForce(new Vector3(0, 0, force));

        }
        
    }
    
}
