using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraProto4 : MonoBehaviour
{
    [SerializeField]
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontaliput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * -horizontaliput * RotationSpeed * Time.deltaTime);
    }
}
