using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class is responsible for service buttons on end game menu after defeat
/// </summary>
public class EndGameMenu : MonoBehaviour {

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
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
	}
}
