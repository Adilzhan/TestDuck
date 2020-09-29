using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
     private float size;
     private float speed;
    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(0.1f,1f);
        gameObject.transform.localScale  = new Vector3(size, size, size);
    }


    private void OnTriggerEnter(Collider other)
    {
         switch(other.tag)
        {
            case "rightDestroyer":
             Destroy(gameObject);
             Timer.score-=1;
            break;
        }
    }

    void Update()
    {
       speed = Random.Range(0.1f,4f);
       Vector3 newPosition = new Vector3 (1, 0, 0);
       transform.Translate (newPosition * Time.deltaTime * speed);
    }

    void OnMouseDown()
        { 
        Destroy(gameObject);
        Timer.score+=1;
         }



}
    
