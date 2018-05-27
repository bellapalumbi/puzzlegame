using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour {

	public GameObject dissolvedSprite;

	public GameObject acid;

	// Use this for initialization

	void Start() {
		//acid = GameObject.Find("acid");
	}
	public void DissolveSelf() {
		print("I, " + gameObject.name + " am dissolving.");
		Invoke("DisappearObject", 1.5f);
		Invoke("ChangeSprite", 1.5f);
		acid.SetActive(false);
	}

	void DisappearObject () {
		gameObject.SetActive(false);
	}

	void ChangeSprite () {
		dissolvedSprite.SetActive(true);
	}
}
