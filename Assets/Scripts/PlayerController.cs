using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public Animator myAnimator;
    public GameObject Projectile;
    public Camera camera;

	// Use this for initialization
	void Start () {
        myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Horizontal") > 0f || Input.GetAxisRaw("Horizontal") < 0f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")*moveSpeed*Time.deltaTime,0f,0f));
        }
        if (Input.GetAxisRaw("Vertical") > 0f || Input.GetAxisRaw("Vertical") < 0f)
        {
            transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            
        }

        myAnimator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        myAnimator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
