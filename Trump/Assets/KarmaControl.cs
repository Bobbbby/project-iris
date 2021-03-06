﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class KarmaControl : MonoBehaviour {

	private Rigidbody rb;
	private Animation anim;
	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animation> ();
	}

	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x, 0, y);
		rb.velocity = movement * 4f;

		if (x != 0 && y != 0) {
			transform.Rotate(20, 0, 0);
			transform.eulerAngles = new Vector3 ((float)-0.2, 0, (float)0.5);

		}
	}
}
