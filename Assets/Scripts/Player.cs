using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character 
{
	private SpriteRenderer plDrw;

	// Use this for initialization
	protected override void Start () {
		plDrw = GetComponent<SpriteRenderer>();

		base.Start ();
		
	}
	
	// Update is called once per frame
	protected override void Update () {
		GetInput ();

		base.Update ();
	}



	private void GetInput(){
		direction = Vector2.zero;

		if (Input.GetKey(KeyCode.W)) {
			direction += Vector2.up;	
		}
		if (Input.GetKey(KeyCode.D)) {
			direction += Vector2.right;
			plDrw.flipX = true;
		}
		if (Input.GetKey(KeyCode.S)) {
			direction += Vector2.down;
		}
		if (Input.GetKey(KeyCode.A)) {
			direction += Vector2.left;
			plDrw.flipX = false;
		}
	}
}
