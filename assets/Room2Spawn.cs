using UnityEngine;
using System.Collections;

public class Room2Spawn : MonoBehaviour {

	public GameObject enemy;
	public GameObject player;
	public GameObject ActualScore;
	bool hasSpawned = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		//print (other.gameObject.tag);
		if ( (other.gameObject.tag == "Player") && (hasSpawned == false) ) {
			// Spawn enemies in Room 2 if player enters room
			print("SPAWNING ROOM 2");
			for (int i = 0; i < 3; i++) {
				GameObject enemy1 = (GameObject)Instantiate(enemy, new Vector3(-112-(10*i),-.2f,-61), Quaternion.identity);
				enemy1.GetComponent<AgentScript> ().target = player.transform;
				enemy1.GetComponent<Enemy> ().ActualScore = ActualScore;
			}
			hasSpawned = true;
		}
	}

}
