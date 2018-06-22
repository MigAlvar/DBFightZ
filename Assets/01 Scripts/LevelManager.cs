using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	private Musical MscManager;

	void ChangeLevel(int index){
		SceneManager.LoadScene(index);
		MscManager.LevelMusic(index);
	}
	
}
