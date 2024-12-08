using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{

    private float Speed = 30;
    private PlayerController controller;

    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.gameOver == false)
        {
        transform.Translate ( -Vector3.right * Speed*Time.deltaTime);

        }
    }
}
