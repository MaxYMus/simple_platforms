﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float maxSpeed;

	Rigidbody2D myRB;
	Animator myAnim;
	bool facingRight;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D>();
		myAnim = GetComponent<Animator>();

		facingRight = true;
		
	}



	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");
		myAnim.SetFloat ("speed", Mathf.Abs (move));

		myRB.velocity = new Vector2 (move * maxSpeed, myRB.velocity.y);

		if (move>0&&!facingRight) {
			flip ();
		} else if (move<0&&facingRight) {
			flip();
		}
	}



	
	// Update is called once per frame
	void Update () {
		
	}

	void flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
