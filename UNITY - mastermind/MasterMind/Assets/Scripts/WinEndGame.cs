using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinEndGame : MonoBehaviour {

	public void QuitGame(){
		Debug.Log ("QUIT");
		Application.Quit ();
	}

	public void NewGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 3);
	}
}
