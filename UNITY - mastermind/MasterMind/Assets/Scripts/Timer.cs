using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// This class is responsible for counting time in game
/// </summary>
public class Timer : MonoBehaviour
{

	public Text timerText;
	private float startTime;

	/// <summary>
	/// Start counting game time.
	/// </summary>
	void Start()
	{
		startTime = Time.time;
	}

	
	/// <summary>
	/// Displaying game time on the board
	/// </summary>
	void Update()
	{
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString();
		string seconds = (t % 60).ToString("f1");

		timerText.text = "TIME IN THIS ROUND: " + minutes + ":" + seconds;
	}
}
