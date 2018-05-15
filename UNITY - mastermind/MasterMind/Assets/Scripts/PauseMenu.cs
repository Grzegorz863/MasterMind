using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject mainGameUI;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
				Resume();
			else
				Pause();
		}
	}
	
	/// <summary>
	/// Return to the game from pause menu
	/// </summary>
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		mainGameUI.SetActive(true);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	/// <summary>
	/// Pause the game
	/// </summary>
	void Pause()
	{
		pauseMenuUI.SetActive(true);
		mainGameUI.SetActive(false);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	/// <summary>
	/// Displaying main menu
	/// </summary>
	public void LoadMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("StartGame");
	}
	/// <summary>
	/// Quit the game
	/// </summary>
	public void QuitGame()
	{
		Application.Quit();
	}
}
