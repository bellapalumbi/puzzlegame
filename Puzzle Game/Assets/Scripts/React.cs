using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour {

	public bool hasBeenHitWithElement = false;
	void OnCollisionEnter2D(Collision2D collider)  {

		hasBeenHitWithElement = true;

		if(collider.gameObject.tag == "ThisIsFire") {
			print("Fire has hit me, " + gameObject.name);
			if (gameObject.GetComponent<Burn>() != null) {
				print("I, " + gameObject.name + "have the Burn script");
				gameObject.GetComponent<Burn>().BurnSelf();
			} 
			

		}
		if(collider.gameObject.tag == "ThisIsIce") {
			print("Ice has hit me, " + gameObject.name);
			if (gameObject.GetComponent<Freeze>() != null) {
				print("I, " + gameObject.name + "have the Freeze script");
				gameObject.GetComponent<Freeze>().FreezeSelf();
				
			} 
		}
		
		if(collider.gameObject.tag == "ThisIsAcid") {
			print("Acid has hit me, " + gameObject.name);
			if (gameObject.GetComponent<Dissolve>() != null) {
				print("I, " + gameObject.name + "have the Dissolve script");
				gameObject.GetComponent<Dissolve>().DissolveSelf();
				
			} 
		}
	
	}


}
