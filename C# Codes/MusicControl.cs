using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour { 
	public AudioClip song0;
	public AudioClip song1;
	public AudioClip song2;
	public AudioClip song3;
	public AudioClip song4;
	public AudioClip song5;
	public AudioClip song6;
	public AudioClip song7;
	public AudioClip song8;
	public AudioClip song9;
	public AudioClip song10;
	public AudioClip song11;
	public AudioClip song12;

	public AudioClip song100;
	public AudioClip song101;
	public AudioClip song102;
	public AudioClip song103;
	public AudioClip song104;
	public AudioClip song105;
	public AudioClip song106;
	public AudioClip song107;
	public AudioClip song108;
	public AudioClip song109;
	public AudioClip song110;
	public AudioClip song111;
	public AudioClip song112;
	public static int i= 3;

	void Start () {
		if (i == 0) {
			AudioSource.PlayClipAtPoint(song0,transform.position);
		}
		if (i == 1) {
			AudioSource.PlayClipAtPoint(song1,transform.position);
		}if (i == 2) {
			AudioSource.PlayClipAtPoint(song2,transform.position);
		}if (i == 3) {
			AudioSource.PlayClipAtPoint(song3,transform.position);
		}if (i == 4) {
			AudioSource.PlayClipAtPoint(song4,transform.position);
		}if (i == 5) {
			AudioSource.PlayClipAtPoint(song5,transform.position);
		}if (i == 6) {
			AudioSource.PlayClipAtPoint(song6,transform.position);
		}if (i == 7) {
			AudioSource.PlayClipAtPoint(song7,transform.position);
		}if (i == 8) {
			AudioSource.PlayClipAtPoint(song8,transform.position);
		}if (i == 9) {
			AudioSource.PlayClipAtPoint(song9,transform.position);
		}if (i == 10) {
			AudioSource.PlayClipAtPoint(song10,transform.position);
		}if (i == 11) {
			AudioSource.PlayClipAtPoint(song11,transform.position);
		}if (i == 0) {
			AudioSource.PlayClipAtPoint(song12,transform.position);
		}

	}


	void Update () {
		
	}
}
