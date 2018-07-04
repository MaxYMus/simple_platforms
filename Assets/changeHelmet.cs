using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeHelmet : MonoBehaviour {

	private SpriteRenderer helm;
	public Sprite[] newhelm;

	// Use this for initialization
	void Start () {
		helm = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			helm.sprite = newhelm [1];
		}
	}
}
