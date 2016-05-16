using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;

	void Start () {
		health = 2000.0f;

	}

	void Update () {
		if (health <= 0.0) {
			Destroy(gameObject);
		}
	}

	// find out if it gets hit
	void OnCollisionEnter(Collision c) {
		Debug.Log (c.collider.name);
		Debug.Log (c.collider.tag);

		if (c.collider.tag == "Rocket") {
			Debug.Log ("ROCKET HIT");

			health = health - 1000.0f;
		}
	}
}
