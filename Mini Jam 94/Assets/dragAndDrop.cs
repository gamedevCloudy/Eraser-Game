using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndDrop : MonoBehaviour
{
  
    private void OnMouseDown() {
        gameObject.GetComponent<breadMovement>().canMove = false; 

    }
}
