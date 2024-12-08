using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] enemy;

    public float posX = 20f ;
    public float posZ = 20f;

    public float start =  2f;
    public float Delay =  5f;


    void Start()
    {
        InvokeRepeating("Spawner", start, Delay);
    }

   
    public void Spawner() {

        int enemyindex = Random.Range(0, enemy.Length);
        Vector3 Spawnpos = new Vector3(Random.Range(-posX, posX), 0, posZ);
        Instantiate(enemy[enemyindex], Spawnpos, (enemy[enemyindex].transform.rotation));

    }

}
