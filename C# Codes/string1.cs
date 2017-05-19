using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class string1 : MonoBehaviour {

	public KeyCode activateString ;
	public int XPos;


	void Start () {
		
	}

	void Update () {
		if( Input.GetKeyDown(activateString) )
		{
			StartCoroutine (moveCollider());
		}
		if( Input.GetKeyUp(activateString) )
		{
			StartCoroutine (removeCollider());
		}

	}



	IEnumerator moveCollider()
	{
		yield return new WaitForSeconds(.015f);
		GetComponent<Transform>().position = new Vector3 (XPos, -0.5f, -3f);
}
			IEnumerator removeCollider()
			{
				yield return new WaitForSeconds(.015f);
		GetComponent<Transform>().position = new Vector3 (XPos, -0.5f, -5f);
					}
}
