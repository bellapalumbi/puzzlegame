using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectWin : MonoBehaviour {


	public Text winText;
	public GameObject dissolved_tent;
	// Use this for initialization

	public GameObject myFire;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(dissolved_tent.activeSelf  && !myFire.activeSelf) {
			//if the tent has been dissolved and if the fire element is not active (wood has been burned)
			Invoke("WinnerWinner", 3);
		}


	}

	void WinnerWinner() {
		winText.gameObject.SetActive(true);
	}

}
