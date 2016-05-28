using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float health;
	public GameObject playerHealth;
	private bool victory = false;

	void Start () {
		print (playerHealth.GetComponent<RectTransform>().offsetMax.x);
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth.GetComponent<RectTransform> ().offsetMax.x <= -144) {
			print ("you dedad");
			Time.timeScale = 0;
		}

	
	}

	void OnCollisionEnter(Collision c) {
		//print ("Player: collision enter");
		//print (c.collider.name);
		//print (c.collider.tag);

		if (c.collider.tag == "Enemy") {
			Debug.Log ("enemy hit");
			health = health - 1000.0f;
		}
	}
	void OnGUI(){
		if(victory){
			GUIStyle style = new GUIStyle ();
			style.fontSize = 22;
			GUI.Label(new Rect(Screen.width/2 - 10, Screen.height/2 - 100, 150, 30), "You Win",
				style);
			Time.timeScale = 0;
		}
	}
	void Hurt(){
		health -= 10.0f;
		float x = playerHealth.GetComponent<RectTransform> ().offsetMax.x;
		float y = playerHealth.GetComponent<RectTransform> ().offsetMax.y;
		playerHealth.GetComponent<RectTransform> ().offsetMax = new Vector2 (x - 14.9f, y);
	}
	void LavaHurt(){
		health -= 10.0f;
		float x = playerHealth.GetComponent<RectTransform> ().offsetMax.x;
		float y = playerHealth.GetComponent<RectTransform> ().offsetMax.y;
		playerHealth.GetComponent<RectTransform> ().offsetMax = new Vector2 (x - 14.9f, y);
	}
	//Activate the Main function when player is near the door
	void OnTriggerEnter (Collider c){
		print ("Player: trigger enter");
		print ("Collider name: " + c.name);
		print ("Collider tag: " + c.tag);
		if (c.gameObject.tag == "Enemy") {
			print ("COLLIDED WITH ENEMY LOOL");
			InvokeRepeating ("Hurt", 0, 0.5F);
		} else if (c.gameObject.tag == "Lava") {
			InvokeRepeating ("LavaHurt", 0, .4f);
		} else if (c.gameObject.tag == "Victory") {
			if (GameObject.Find ("Enemy") == null && GameObject.Find ("Enemy(Clone)") == null) {
				print ("no enemies - victory");
				victory = true;
			} else {
				print ("found enemies - victory");
			}
		}
	}

	//Deactivate the Main function when player is go away from door
	void OnTriggerExit (Collider c){
		//print ("Player: trigger exit");
		//print (c.tag);
		if (c.gameObject.tag == "Enemy") {
			CancelInvoke ("Hurt");
		}
		else if (c.gameObject.tag == "Lava") {
			CancelInvoke ("LavaHurt");
		}
	}
}
