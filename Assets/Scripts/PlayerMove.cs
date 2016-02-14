using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float scroll = 2.0f;
	public int jumpSpeed = 300;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().AddForce(Vector2.right * scroll);
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSpeed);


		}


	}
}
