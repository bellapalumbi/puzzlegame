using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour {

	private Vector3 offset;
	void OnMouseDown () {
		//moves object in relation to the mouse drag by finding the 'offset' using camera.main.screentoworld point. The 10.0f is the distance from the cam to object
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
	}
	
	void OnMouseDrag() {
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
	}
}
