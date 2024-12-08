using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontal;
    public float Speed = 10f;
    private float xBoundary = 20;
    public GameObject ShootFood;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {

             Instantiate(ShootFood,transform.position ,ShootFood.transform.rotation);
        }

        if (transform.position.x <-xBoundary)
        {
            transform.position = new Vector3 (-xBoundary , 0, 0);  
        }
        if (transform.position.x > xBoundary)
        {
            transform.position = new Vector3(xBoundary, 0, 0);
        }
        horizontal = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right*horizontal*Time.deltaTime*Speed  );
    }
}
