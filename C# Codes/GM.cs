using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public void StopBTN(string name){
		nn = 0;
		TimerReset = "n";
		SceneManager.LoadScene(name);
	}
	public static int nn = 1;
	public static int RunningTime = 0;
	public int WhichNote = 1;
	public int NoteMark = 0;
	public Transform NoteObj;
	public static string TimerReset = "y";
	public float XPos;
	public static int WinStreak = 0;
	public static int CorrectNotes = 0;
	public static float TotalScore = 0;
	public static int Multiply = 0;
	public static float TimeDif = 0.5f;
	public static string PlayerName;


	void Start () {
		
	}

	void Update () {
		if( nn == 1){
			RunningTime++ ;}
		if (TimerReset == "y")
		{
			StartCoroutine (SpawnNote ());
			TimerReset = "n";
		}
	}

	IEnumerator SpawnNote()
	{
		WhichNote = Random.Range (0, 4);
		yield return new WaitForSeconds (TimeDif);
		if (WhichNote  == 1) {
			XPos = 1;
		}
		if (WhichNote  == 2) {
			XPos = 0;
		}
		if (WhichNote == 3) {
			XPos = -1;
		}


		NoteMark += 1;
		TimerReset = "y";
		Instantiate (NoteObj, new Vector3 (XPos, 0.9f, 2.2f), NoteObj.rotation);

	}
}
