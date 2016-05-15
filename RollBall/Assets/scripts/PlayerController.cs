using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){

		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveH, 0.0f, moveV);
		rb.AddForce (movement*speed);
	}
}
