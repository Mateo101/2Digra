using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgraceKontrole : MonoBehaviour {

    public float speed;
    public KeyCode gore;
    public KeyCode dolje;
    public KeyCode pucaj1;
    public KeyCode pucaj2;
    public Rigidbody2D tijelo;
    public Rigidbody2D tijelo2;
    Vector2 smejrKretanjaX = new Vector2(1, 0) ;
    Vector2 smejrKretanjay= new Vector2(0, 1);

    public void pucajF1()
    {

    }

    public void pucajF2()
    {

    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey(pucaj1))
        {
            pucajF1();
        }
        if (Input.GetKey(pucaj2))
        {
            pucajF2();
        }

        tijelo.velocity = new Vector2(speed, 0);
        if (Input.GetKey(gore))
        {
            tijelo.velocity = new Vector2(speed -15, speed-10);
        } else if (Input.GetKey(dolje))
        {
            tijelo.velocity = new Vector2(speed -15, -speed-10);
        } else
        {
            //tijelo.velocity = new Vector2(0, 0);
        }
	}
}
