using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
     
        Destroy(gameObject);
        Destroy(other.gameObject);

    }
   
}
