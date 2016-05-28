
using UnityEngine;
using System.Collections;

public class Room3Spawner : MonoBehaviour {

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
			for (int j = 0; j < 2; j++) {
				for (int i = 0; i < 10; i++) {
					GameObject enemy1 = (GameObject)Instantiate(enemy, new Vector3(68+20*j,-.2f,-82+(10*i)), Quaternion.identity);
					enemy1.GetComponent<AgentScript> ().target = player.transform;
					enemy1.GetComponent<Enemy> ().ActualScore = ActualScore;
				}
			}
			hasSpawned = true;
		}
	}

}
