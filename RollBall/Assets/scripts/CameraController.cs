using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame. runs after all items have been processed in update. 
	// This way the player movement has been updated
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
