using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visual4 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		GetComponent<TextMesh> ().text = "time: "+ GM.RunningTime/6000+ ":" + GM.RunningTime/100+ ":" +GM.RunningTime%100 ; 
	}
}
