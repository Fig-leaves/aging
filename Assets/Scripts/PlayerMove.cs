using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float scroll = 2.0f;

	public int jumpCount = 1;
	public int defaultJumpCount = 1;

	public int Life = 3;



	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// transform.Translate(Vector2.right * Time.deltaTime * scroll, Camera.main.transform);
		GetComponent<Rigidbody2D>().AddForce(Vector2.right * scroll);

		if (Input.GetKeyDown("space") && jumpCount > 0) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * 450);
			jumpCount -= 1;
		}
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Ground") {
			jumpCount = defaultJumpCount;
		}
		else if (coll.gameObject.tag == "Boots") {
			defaultJumpCount += 1;
			Destroy(coll.gameObject);
		}
		else if (coll.gameObject.tag == "Enemy") {
			Life -= 1;
			Destroy(coll.gameObject);
			Debug.Log(Life);
		}
		else if (coll.gameObject.tag == "Item") {
			Life += 1;
			Destroy(coll.gameObject);
			Debug.Log(Life);
		}


	}

}
