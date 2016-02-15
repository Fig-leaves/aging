using UnityEngine;
using System.Collections;

public class Damege : MonoBehaviour {
	public int Life = 3;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col) {

		//  on damage
		if (col.gameObject.tag == "Enemy") {
			Life -= 1;
			Debug.Log(Life);
			Destroy(col.gameObject);

		}
		else if (col.gameObject.tag == "Item") {
			Life += 1;
			Debug.Log(Life);
			Destroy(col.gameObject);
		}
}

}
