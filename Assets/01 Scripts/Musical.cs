using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musical : MonoBehaviour {

	[Header("Level Theme Music")]
	[SerializeField] private List <AudioClip> music = new List <AudioClip>();
	private AudioSource Snd;
	private float vol, MAX = 1.0f;

	// Use this for initialization
	void Start () {
		Snd = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void LevelMusic(int index){
			if(music[index] == null){
				Snd.Stop();
			}
			else{
				Snd.clip = music[index];
				Snd.Play();
			}
	}

	void Fader(bool io){
		if(io){
			while(vol < MAX){
				vol += Time.deltaTime/10;
			}
		}else{
			while(vol > 0){
				vol -= Time.deltaTime/10;
			}
		}

		Snd.volume = vol;
	}
}
