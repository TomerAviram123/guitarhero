using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visual1 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		GetComponent<TextMesh> ().text = "Score: " + GM.TotalScore;
	}
}
