using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	// The fly speed (used by the weapon later)
	public float speed = 2500.0f;



	// find out when it hit something
	void OnCollisionEnter(Collision c) {

		Destroy(gameObject);
	}
}