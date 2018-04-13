using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour {


	public void ResumeGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	public void QuitGame(){
		Debug.Log ("QUIT");
		Application.Quit ();
	}



	public void NewGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);



	}
}
