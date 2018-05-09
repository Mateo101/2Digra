using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SudarSkripta : MonoBehaviour {
           
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.collider.tag == "Igrac")
        {
            Debug.Log("sudar se desio");
            
            Destroy(gameObject);
        }
    }


    
}
