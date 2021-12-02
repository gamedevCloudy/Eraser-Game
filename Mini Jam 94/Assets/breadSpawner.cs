using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadSpawner : MonoBehaviour
{
    public GameObject goodBread; 
    public GameObject badBread; 
    private float timeBtwSpawn; 
    public float startTimeBtwSpawn; 
    private float decreaseTime = 0.05f; 
    private float minTime = 1f; 


    
    void Update()
    {
        
        if(timeBtwSpawn <=0)
        {
            if(Random.value > 0.3)
            {
                Instantiate(badBread, transform.position, transform.rotation); 
            }
            else Instantiate(goodBread, transform.position, transform.rotation); 
            timeBtwSpawn = startTimeBtwSpawn; 
            if(startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime; 
            }
            
        }
        else timeBtwSpawn -= Time.deltaTime; 
    }
}
