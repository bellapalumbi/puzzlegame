using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour {

	public bool isSmoke = false;
	
	public GameObject fire;
	public ParticleSystem Smoke;
	private Vector2 currentPos;

	void Start() {
		currentPos = gameObject.transform.position;
		//fire = GameObject.Find("fire");
	}

	
	public void BurnSelf() {
		if(!isSmoke) {
			print("I, " + gameObject.name + " am burning");
			GameObject smoke = (GameObject)Instantiate(Resources.Load("Smoke"), new Vector2(currentPos.x-3, currentPos.y-1), new Quaternion(40,40,0,1));
			print ("Smoke instantiated.");
			isSmoke = true;
			Destroy(smoke, 5);
		}
		Invoke("DisappearObject", 5);
		fire.SetActive(false);

	}
	void DisappearObject() {
		gameObject.SetActive(false);
	}
}
