using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {
	[SerializeField]
	private float speed = 3.0f;

	protected Vector2 direction;

	private Rigidbody2D myRB;

	// Use this for initialization
	protected virtual void Start () {
		myRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		
	}

	private void FixedUpdate()
	{
		Move ();
	}

	public void Move(){
		myRB.velocity = direction.normalized * speed;
	}
}
