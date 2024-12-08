using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Proto4SpawnManager : MonoBehaviour
{
    public GameObject enemySphere;
    private float SpawnRange = 9f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemySphere, GenerateSphere(), enemySphere.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private  Vector3 GenerateSphere()
    {

        float posX = Random.Range(-SpawnRange, SpawnRange);
        float posz = Random.Range(-SpawnRange, SpawnRange);

        Vector3 pos = new Vector3(posX, 0, posz);
         return pos;

       
    }


}
