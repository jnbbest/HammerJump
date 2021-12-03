using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public static ControlScript instance;
    private Vector3 targetPosition;
    public bool isMoving;
    public float speed = 5f;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    public Transform player;
    
    public float miny, maxy,fixedX;
    //public Animation anim;
    private void Awake()//
    {
        instance = this;
    }
    void Start()
    {
        //anim = gameObject.GetComponent<Animation>();

    }

    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        else
        {
            isMoving = false;
        }
        if(isMoving)
        {
            Move();
        }
        
        
    }

    void SetTargetPosition()
    {
        Ray myray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(myray, out hit, 1000))
        {
            targetPosition = hit.point;
            //this.transform.LookAt(targetPosition);
            //lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.y);
            isMoving = true;
            //playerRot = Quaternion.LookRotation(lookAtTarget);
        }

    }

    void Move()
    {
        //transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, speed * Time.deltaTime);
        
        Vector3 rot = Vector3.MoveTowards(player.position, targetPosition, speed * Time.deltaTime);
        rot.y = Mathf.Clamp(rot.y, miny, maxy);
        rot.x = fixedX;
        player.position = rot;
        if (player.position == targetPosition)
        {
            isMoving = false;
        }
    }

}
