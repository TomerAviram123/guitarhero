using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour {

	public Transform Wall1;
	public Transform Wall2;
	public static int i = 1;

	void Start () {

		if (i == 0) {
			Instantiate (Wall1);
		}
		if (i == 1) {
			Instantiate (Wall2);
		}
		
		
	}

	void Update () {
		
	}
}
