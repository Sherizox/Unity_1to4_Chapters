using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedforwad ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(transform.position.z > speedforwad)
        //{
        //    Destroy(gameObject);
        //    Debug.Log("gameobject_destroyed");
        //}
        transform.Translate(Vector3 .forward *Time.deltaTime*speedforwad);
    }
}
