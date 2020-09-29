using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpawner : MonoBehaviour
{
        public GameObject bird;
        float y;
        int objectsCount;
        bool canSpawn=true;
    

    void Start()
    {
        
    }

     void Update()
    {   
            if (canSpawn){
         StartCoroutine("SpawnBird");}
        
           
    }

    IEnumerator SpawnBird(){

        objectsCount=Random.Range(0,10);
       
     for (int x=0; x<objectsCount; ++x)
           { y = Random.Range(-3f,3f);
        GameObject block = Instantiate(bird, new Vector3(-11.4f,y,2.3f), Quaternion.identity);
         
           }
            canSpawn=false;
           yield return null;
    }
}
