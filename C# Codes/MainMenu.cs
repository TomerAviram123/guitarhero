using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Slider speedBTN;
	public void SpeedBTN( string name){
		GM.TimeDif = 10 - speedBTN.value;
	}
	public void StartBTN(string name){
		SceneManager.LoadScene(name);
		GM.TimerReset = "y";
		GM.nn = 1;
	}
	public void QuitBTN(string name){
		SceneManager.UnloadSceneAsync(name);
	}
	public void NameBTN(string name){
		GM.PlayerName = Input.inputString ;
	}
	public void SongBTN(string name){
		MusicControl.i = int.Parse(Input.inputString);
	}


		
}
