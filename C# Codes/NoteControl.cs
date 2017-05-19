using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteControl : MonoBehaviour {

	public Transform sucessBurst;
	public Transform failBurst;

	void Start () {
		
	}

	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "failcollider")
		{
			Destroy (gameObject);
			Debug.Log ("fail!!!");
			Instantiate (failBurst, transform.position,failBurst.rotation);
			GM.WinStreak = 0;
			GM.TotalScore -= 1;


		}
		else if (other.name == "sucesscollider1" || other.name == "sucesscollider2" || other.name == "sucesscollider3"  )
		{
			Destroy (gameObject);
			Debug.Log ("sucess!!!");
			Instantiate (sucessBurst, transform.position,sucessBurst.rotation);
			GM.WinStreak += 1;
			GM.CorrectNotes += 1;
			    if (GM.WinStreak >= 3) {
				GM.Multiply = 2;
			}   if (GM.WinStreak >= 6) {
				GM.Multiply = 3;
			}   if (GM.WinStreak >= 9) {
				GM.Multiply = 4;
			}   if (GM.WinStreak >= 12) {
				GM.Multiply = 5;
			}	if (GM.WinStreak >= 15) {
				GM.Multiply = 6;
			}	if (GM.WinStreak >= 18) {
				GM.Multiply = 7;
			}
			GM.TotalScore += GM.Multiply;

		}
	}
}
