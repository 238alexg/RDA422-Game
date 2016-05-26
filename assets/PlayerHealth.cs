using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int health;

    bool wasHit;

	// Use this for initialization
	void Start () {
        health = 100;
        wasHit = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0.0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }

    // find out if it gets hit
    void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.collider.name);
        Debug.Log(c.collider.tag);

        if (c.collider.tag == "Enemy")
        {
            Debug.Log("PLAYER HIT");
            health = health - 10;
        }
    }
}
