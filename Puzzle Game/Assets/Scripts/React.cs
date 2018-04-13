using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour {

	private Burn Burn;
	//create new object of type Burn script called Burn
	private Freeze Freeze;
	void Start () {
		Burn = gameObject.GetComponent<Burn>();
		//stores the Burn script on this object (existing or not)
		//on Burn
		Freeze = gameObject.GetComponent<Freeze>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collider)  {
		if(collider.gameObject.tag == "ThisIsFire") {
			print("Fire has hit me, " + gameObject.name);
			if (gameObject.GetComponent<Burn>() != null) {
				gameObject.GetComponent<Burn>();
			} 
		}
		if(collider.gameObject.tag == "ThisIsIce") {
			print("Ice has hit me, " + gameObject.name);
			if (gameObject.GetComponent<Freeze>() != null) {
				gameObject.GetComponent<Freeze>();
			} 
		}
	}
}
