using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
public class Enemy : MonoBehaviour {

	public float health;
	public string score_text;
	public GameObject ActualScore;
	public GameObject playerHealth;
	public float score;
	public int healthBar;

	void Start () {
		ActualScore = GameObject.FindWithTag ("Player");
		score_text = ActualScore.GetComponent <Text>().text;
		score = float.Parse(score_text.ToString());
		health = 2000.0f;
	}

	void Update () {
		if (health <= 0.0) {
			print ("SCORE TEXT " + score_text.ToString ());
			score_text = ActualScore.GetComponent <Text>().text;
			score = float.Parse(score_text.ToString()) + 100;
			score_text = "" + score;
			ActualScore.GetComponent <Text> ().text = score_text;
			Destroy(gameObject);
		}
	}

	// find out if it gets hit
	void OnCollisionEnter(Collision c) {
		//print (c.collider.name);
		//print ("tag: " + c.collider.tag);
		if (c.collider.tag == "Rocket") {
			Debug.Log ("ROCKET HIT");
			score_text = ActualScore.GetComponent <Text> ().text;
			score = float.Parse (score_text.ToString ()) + 10;
			score_text = "" + score;
			ActualScore.GetComponent <Text> ().text = score_text;
			health = health - 1000.0f;
		} else if (c.collider.tag == "Rifle") {
			Debug.Log ("ROCKET HIT");
			score_text = ActualScore.GetComponent <Text> ().text;
			score = float.Parse (score_text.ToString ()) + 4;
			score_text = "" + score;
			ActualScore.GetComponent <Text> ().text = score_text;
			health = health - 400.0f;
		} else if (c.collider.tag == "Uzi") {
			Debug.Log ("ROCKET HIT");
			score_text = ActualScore.GetComponent <Text> ().text;
			score = float.Parse (score_text.ToString ()) + 2;
			score_text = "" + score;
			ActualScore.GetComponent <Text> ().text = score_text;
			health = health - 200.0f;
		} 
	}
}
