using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgraceKontrole : MonoBehaviour {

    public float speed;
    public KeyCode gore;
    public KeyCode dolje;
    public Rigidbody2D tijelo;
    bool zid = false;
    
    // Update is called once per frame
    void FixedUpdate () {

        
        if (Input.GetKey(gore))
        {
            tijelo.velocity = new Vector2(speed - 5, speed + 2);
        } else if (Input.GetKey(dolje))
        {
            tijelo.velocity = new Vector2(speed - 5, -speed - 5);
        } else
        {
            tijelo.velocity = new Vector2(speed, 0);
        }
	}
}
