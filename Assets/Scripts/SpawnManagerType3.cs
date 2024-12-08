using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerType3 : MonoBehaviour

{
    public GameObject Obstacle;
    private Vector3 pos=new Vector3(25,0,0);
    private float start = 2 ;
    private float end = 2;
    private PlayerController controller;

 
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("ReSpawn",start,end);
    }
    void ReSpawn()
    {
        if (controller.gameOver == false)
        {
            Instantiate(Obstacle, pos, Obstacle.transform.rotation);
        }
    }
}
