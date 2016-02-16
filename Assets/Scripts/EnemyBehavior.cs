using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	// Use this for initialization
	private float enemySwitc;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		enemySwitc = Time.deltaTime;
		if (enemySwitc < 2) {
			this.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 2.0f);
			enemySwitc = 0;
		}



	}
}
