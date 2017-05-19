using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigger : MonoBehaviour {

	public KeyCode Trigger;
	void Start () {
		
	}

	void Update () {
		if (Input.GetKeyDown (Trigger)) {
			GetComponent<BoxCollider> ().isTrigger = true;
		} else {
			GetComponent<BoxCollider> ().isTrigger = true;
		}
	}
}
