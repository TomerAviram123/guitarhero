using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visual2 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		GetComponent<TextMesh> ().text = "Crrect Notes: " + GM.CorrectNotes;
	}
}
