using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, -10f);
        transform.position = thePlayer.transform.position + new Vector3(0f, 0f, -10);
	}
}
