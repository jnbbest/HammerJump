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
    public Transform obs;
    float m_ScaleX, m_ScaleY, m_ScaleZ;
    public float sizer = .2f;
    private void Awake()//
    {
        instance = this;
    }
        // Start is called before the first frame update
        void Start()
    {
        controlScript = ControlScript.instance;
        
        //These are the starting sizes for the Collider component
        
        m_ScaleZ = 4.4f;
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
               
                m_ScaleZ -= sizer;
                obs.localScale = new Vector3(3.7f,3.7f,m_ScaleZ);
                //Debug.Log("Current BoxCollider Size : " + m_Collider.size);
                
                //oppforce.AddForce(new Vector3(0, 0, 100f));
                
               //oppforce.useGravity = false;    
                if (health <= 0)
                {
                    DestroyMe();
                    //controlScript.currentPower = 1f;
                }

            }
        }
    }

    void DestroyMe()
    {
        gameObject.SetActive(false);

    }
}
