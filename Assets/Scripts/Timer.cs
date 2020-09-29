using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentTime;
    float startingTime = 30f;
    public static float score=10;
     [SerializeField]Text countdownText;
     [SerializeField]Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime -= 1 *Time.deltaTime;
        countdownText.text =currentTime.ToString("0");
         scoreText.text = score.ToString();

        if (Input.GetKeyDown("up"))
        {
            StartCoroutine("addTime");
        }
        if (currentTime <=0){
            currentTime=0;
        }
        if (score <=0){
            score=0;
        }
        
    }
    IEnumerator addTime(){
{ currentTime =currentTime+3;
	
	yield return currentTime;
    }


	
}
}
