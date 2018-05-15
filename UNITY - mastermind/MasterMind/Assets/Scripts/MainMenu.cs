using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	/// <summary>
	/// Begin new game
	/// </summary>
	public void PlayGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
	}

	/// <summary>
	/// Quit the game and program
	/// </summary>
	public void ExitGame()
	{
		Debug.Log ("QUIT");
		Application.Quit ();
	}
}
