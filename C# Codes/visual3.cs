using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visual3 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		GetComponent<TextMesh> ().text ="Streak: " + GM.WinStreak;
	}
}
