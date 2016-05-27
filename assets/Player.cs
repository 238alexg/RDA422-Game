using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	//public GameObject rocketPrefab;
	//public GameObject riflePrefab;
	//public GameObject uziPrefab;
	//public GameObject curWeapon;
	public float health;
	//public Vector3 rifle_pos;
	//public Vector3 rocket_pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			print ("you dedad");
			Time.timeScale = 0;
		}

		if(Input.GetKeyDown("1")){
			foreach(Transform child in transform){
				if (child.tag != "Rocket") {
					child.gameObject.SetActive (false);
				} else {
					child.gameObject.SetActive (true);
				}
			}
			//GameObject g = (GameObject)Instantiate (rocketPrefab);
			//g.transform.parent = transform;
			//g.transform.position =  new Vector3 (transform.position.x + rifle_pos.x,
		//		transform.position.y + rifle_pos.y, transform.position.z + rifle_pos.z);
			
		}else if(Input.GetKeyDown("2")){
			foreach(Transform child in transform){
				if (child.tag != "Rifle") {
					child.gameObject.SetActive (false);
				}else{
					child.gameObject.SetActive (true);
				}		
			}

		}else if(Input.GetKeyDown("3")){
			foreach(Transform child in transform){
				if (child.tag != "Uzi") {
					child.gameObject.SetActive (false);
				}else{
					child.gameObject.SetActive (true);
				}		
			}
		}
	}

	void OnCollisionEnter(Collision c) {
		print ("Player: collision enter");
		//print (c.collider.name);
		print (c.collider.tag);

		if (c.collider.tag == "Enemy") {
			Debug.Log ("enemy hit");
			health = health - 1000.0f;
		}
	}

	//Activate the Main function when player is near the door
	void OnTriggerEnter (Collider c){
		print ("Player: trigger enter");
		print (c.tag);
		if (c.gameObject.tag == "Enemy") {
			print ("COLLIDED WITH ENEMY LOOL");
			health -= 100.0f;
		}
	}

	//Deactivate the Main function when player is go away from door
	void OnTriggerExit (Collider c){
		print ("Player: trigger exit");
		print (c.tag);
		if (c.gameObject.tag == "Player") {
		}
	}
}
