using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadMovement : MonoBehaviour
{
    public int speed; 
   public bool isOverCooked = false; 
   public bool canMove = true; 

    private GameObject manager; 
    private GameManager gameManager; 
    
    private void Start() {
        manager = GameObject.Find("Game Manager"); 
        gameManager = manager.GetComponent<GameManager>(); 
    }
    void Update()
    {
       
       if(canMove) transform.Translate(Vector2.left * speed * Time.deltaTime); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with " + other.tag); 
        if(other.tag == "End Line" && isOverCooked)
        {
            gameManager.UpdateScore(-25); 
            Destroy(gameObject); 
        }
        if( other.tag == "End Line" && isOverCooked == false)
        {
            gameManager.UpdateScore(25); 
            Destroy(gameObject); 
        }
    }
}
