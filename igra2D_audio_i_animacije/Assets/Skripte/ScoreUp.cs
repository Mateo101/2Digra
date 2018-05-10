using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreUp : MonoBehaviour {

    public Text score;
    int broj = 0;
    bool crveni = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "CrveniDijamant")
        {
            Debug.Log("sudar se desio");

            crveni = true;
        }
    }

    // Update is called once per frame
    void Update () {
        
        if(crveni)
        {
            broj = Int32.Parse(score.text) + 10;
            crveni=false;
        }
        
        score.text = broj.ToString();

    }
}
