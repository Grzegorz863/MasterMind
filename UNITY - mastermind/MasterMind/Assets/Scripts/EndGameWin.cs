using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameWin : MonoBehaviour {

	/// <summary>
	/// Quit the game
	/// </summary>
	public void QuitGame()
	{
		Debug.Log ("QUIT");
		Application.Quit ();
	}

	/// <summary>
	/// Begin new game
	/// </summary>
	public void NewGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 3);
	}
}
