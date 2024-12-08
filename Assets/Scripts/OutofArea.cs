using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofArea : MonoBehaviour
{
    [SerializeField]
    public float ForwardArea  ;
    public float backwardArea  ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z > ForwardArea)
        {
            Destroy(gameObject);
        } if(gameObject.transform.position.z < backwardArea)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
