using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollMoveProto4 : MonoBehaviour
{
    private Rigidbody Playerrb;
    public float Speed = 0.5f;

    public bool hasPower;
    private GameObject MidPoint;
    // Start is called before the first frame update
    void Start()
    {
        MidPoint = GameObject.Find("MidCameraMove");
        Playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputVertical = Input.GetAxis("Vertical");
        Playerrb.AddForce(MidPoint.transform.forward* inputVertical * Speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PowerUP"))
        {
            hasPower = true;
            Destroy(other.gameObject);

        }
    }
}
