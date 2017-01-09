using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour {
	public float velocidad = 1f;
	Rigidbody2D rgb;
	// Use this for initialization
	void Start () {
		rgb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		Vector2 v = new Vector2 (velocidad, 0);
		rgb.velocity = v;
	}
}
