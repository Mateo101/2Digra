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
            
            // disableat collider diamanta
            GetComponent<BoxCollider2D>().enabled = false;

            // dobi komponentu brzine zbog prvotne detekcije kolizije , pa je ovdje poništim
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

            FindObjectOfType<AudioManager>().Sviraj("SkupiDijamant");

            // aktiviranje početno disabled animatora
            GetComponent<Animator>().enabled = true;
            
            /* uništit cemo ga u drugoj skripti jer pokazujemo animaciju*/
            //Destroy(gameObject);
        }
    }


    
}
