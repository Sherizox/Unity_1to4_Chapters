using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollMovePlayer : MonoBehaviour
{

    public float speed = 10.0f ;
    private float zBound = 6f;
    private Rigidbody BollBody;
   

    // Start is called before the first frame update
    void Start()
    {
        BollBody = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        GetCompOnPlayer();
        PlayerRange();


    }
    void GetCompOnPlayer()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        BollBody.AddForce(Vector3.forward * speed  * Vertical);
        BollBody.AddForce(Vector3.right * speed * Horizontal);
    }
    
    void PlayerRange()
    {
        if(transform.position.z < -zBound)
        {
            transform.position= new Vector3(transform.position.x,transform.rotation.y,-zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.rotation.y, zBound);
        }
    }



}
