using UnityEngine;
using System.Collections;

public class WeaponSwap : MonoBehaviour {


	// Update is called once per frame
	void Update () {

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

}
