using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphere : MonoBehaviour
{
    public float Speed = 3f;
    private Rigidbody Sphererb;

    private GameObject PlayerSphere;

    // Start is called before the first frame update
    void Start()
    {
        PlayerSphere = GameObject.Find("PlayerSphere");
       Sphererb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 EnemyPos = (PlayerSphere.transform.position - transform.position).normalized;


        Sphererb.AddForce(EnemyPos* Speed);

        
    }
}
