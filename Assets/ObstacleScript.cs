using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public static ObstacleScript instance;
    private ControlScript controlScript;
    
    public float _health = 5f;
  
    public float _damage = 1;
    //public Rigidbody oppforce;
    [SerializeField]
    private float timer;
    //public GameObject smokeExplode;

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


    private void OnCollisionStay(Collision collision)
    {
        
        timer += Time.deltaTime;
        if (timer >= .3f)
        {
            timer = 0;

            foreach (ContactPoint contact in collision.contacts)
            {

                if (contact.otherCollider.CompareTag("Player"))
                {
                    _health -= _damage;
                    
                    
                    if (_health <= 0)
                    {
                        DestroyMe();

                    }

                }
            }
        }
    }
    

    void DestroyMe()
    {
        
        gameObject.SetActive(false);

    }
    
}
