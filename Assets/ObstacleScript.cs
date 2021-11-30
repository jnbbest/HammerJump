using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public static ObstacleScript instance;
    private ControlScript controlScript;
    public float health = 5f;
    public float damage;
    //public Rigidbody oppforce;
    
    
    
    private void Awake()//
    {
        instance = this;
    }
        // Start is called before the first frame update
        void Start()
    {
        
        
        
        
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        foreach (ContactPoint contact in collision.contacts)
        {

            if (contact.otherCollider.CompareTag("Player"))
            {

                health--;
                if (health <= 0)
                {
                    DestroyMe();
                    
                }

            }
        }
    }

    void DestroyMe()
    {
        gameObject.SetActive(false);

    }
}
