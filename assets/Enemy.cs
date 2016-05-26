using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
	public Text score_text;
	public GameObject ActualScore;
	public int score;

	void Start () {
		ActualScore = GameObject.FindWithTag ("Player");
		score_text = ActualScore.GetComponent <Text>();
		score = 0;
		score_text.text = "" + score;
		health = 2000.0f;
	}

	void Update () {
		if (health <= 0.0) {
			ActualScore = GameObject.FindWithTag ("HUD");
			score_text = ActualScore.GetComponent <Text>();
			//score = score + 100;
			//score_text.text = "" + score;
			Destroy(gameObject);
		}
	}

	// find out if it gets hit
	void OnCollisionEnter(Collision c) {
		print (c.collider.name);
		print (c.collider.tag);

		if (c.collider.tag == "Rocket") {
			Debug.Log ("ROCKET HIT");
			score = score + 10;
			score_text.text = "" + score;
			health = health - 1000.0f;
		}
		else if (c.collider.tag == "Rifle") {
			Debug.Log ("ROCKET HIT");
			score = score + 4;
			score_text.text = "" + score;
			health = health - 400.0f;
		}
		else if (c.collider.tag == "Uzi") {
			Debug.Log ("ROCKET HIT");
			score = score + 2;
			score_text.text = "" + score;
			health = health - 200.0f;
		}
	}
}
