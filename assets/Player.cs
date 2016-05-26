using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		print ("Player: collision enter");
		print (c.collider.name);
		print (c.collider.tag);

		if (c.collider.tag == "Enemy") {
			Debug.Log ("enemy hit");
			health = health - 1000.0f;
		}
	}

	//Activate the Main function when player is near the door
	void OnTriggerEnter (Collider c){
		print ("Player: trigger enter");
		print (c.name);
		print (c.tag);
		if (c.gameObject.tag == "Enemy") {
			print ("COLLIDED WITH ENEMY LOOL");
		}
	}

	//Deactivate the Main function when player is go away from door
	void OnTriggerExit (Collider c){
		print ("Player: trigger exit");
		print (c.name);
		print (c.tag);
		if (c.gameObject.tag == "Player") {
		}
	}
}
