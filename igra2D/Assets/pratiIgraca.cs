using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pratiIgraca : MonoBehaviour {

    public Transform igrac;
    Vector3 udalji = new Vector3(3, 0, -10);
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(igrac.position.x + 3, 0, -10);
	}
}
