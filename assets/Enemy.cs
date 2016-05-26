using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
    private Text score_text;
    public GameObject ActualScore;
    int score;

	void Start () {
        ActualScore = GameObject.FindWithTag("Player");
        score_text = ActualScore.GetComponent <Text>();
        score = 0;
        score_text.text = "" + score;
        health = 3000.0f;
	}

	void Update () {
		if (health <= 0.0) {
			Destroy(gameObject);
            score = score + 90;
            score_text.text = "" + score;
		}
	}

	// find out if it gets hit
	void OnCollisionEnter(Collision c) {
		Debug.Log (c.collider.name);
		Debug.Log (c.collider.tag);

		if (c.collider.tag == "Rocket") {
			Debug.Log ("ROCKET HIT");
            score = score + 10;
            score_text.text = "" + score;
			health = health - 1000.0f;
		}
	}
}
