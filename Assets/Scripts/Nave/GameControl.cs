using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {


	void Start(){
		
	}



	void Update () {
	}

	public void respawn(){
			SceneManager.LoadScene ("Nave");

	}
	
}
