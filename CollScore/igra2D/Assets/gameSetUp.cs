using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSetUp : MonoBehaviour {

    public Camera glavnaKamera;

    public BoxCollider2D gornjiZid;
    public BoxCollider2D donjiZid;

    public Transform igrac;//Hocemo da 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gornjiZid.size = new Vector2(glavnaKamera.ScreenToWorldPoint(new Vector3(Screen.width* 2f , 0f , 0f)).x, 1f);
        gornjiZid.offset = new Vector2(glavnaKamera.ScreenToWorldPoint(new Vector3(Screen.width / 2f, 0f, 0f)).x,
                                    glavnaKamera.ScreenToWorldPoint(new Vector3(0f, Screen.height , 0f)).y + 0.5f);

        donjiZid.size = new Vector2(glavnaKamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        donjiZid.offset = new Vector2(glavnaKamera.ScreenToWorldPoint(new Vector3(Screen.width / 2f, 0f, 0f)).x,
                                    glavnaKamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
    }
}
