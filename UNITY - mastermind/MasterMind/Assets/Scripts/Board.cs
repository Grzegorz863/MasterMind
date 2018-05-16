using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// The most important class in project
/// </summary>
/// <remarks>Class contain all Mastermind algorithm</remarks>
[RequireComponent(typeof(Animator))]
public class Board : MonoBehaviour
{

	GameObject code;
	GameObject code2;
	GameObject compare;
	GameObject compare2;
	GameObject compare3;
	GameObject compare4;
	Transform child;
	Transform child2;
	int counter = 0;
	int hit = 0;
	int halfHit = 0;
	GameObject cipher;
	Color randomColor;
	GameObject chest;
	ChestAnimation chestAnimation = new ChestAnimation();
	private float timer = 0;

	public GameObject pauseMenu;
	public GameObject mainGame;

	/// <summary>
	/// Closing game
	/// </summary>
	public void QuitGame()
	{
		pauseMenu.SetActive(true);
		mainGame.SetActive(false);
	}

	/// <summary>
	///	Return to the main game menu
	/// </summary>
	public void NewGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	/// <summary>
	/// Draw random color to cipher
	/// </summary>
	void randomColorSet()
	{
		int number = Random.Range(1, 7);

		switch (number)
		{
			case 1:
				randomColor = Color.cyan;
				break;
			case 2:
				randomColor = Color.green;
				break;
			case 3:
				randomColor = Color.white;
				break;
			case 4:
				randomColor = Color.red;
				break;
			case 5:
				randomColor = Color.yellow;
				break;
			case 6:
				randomColor = Color.magenta;
				break;
		}
	}

	/// <summary>
	/// Displays hints for the user-entered cipher
	/// </summary>
	/// <param name="number">line number on the board</param>
	public void showHit(int number)
	{

		Debug.Log("showhint0");

		if (hit >= 1)
		{
			cipher = GameObject.Find("result" + number.ToString() + "1");
			cipher.GetComponent<Renderer>().material.color = Color.black;
			if (halfHit >= 1)
			{
				cipher = GameObject.Find("result" + number.ToString() + "2");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}
			if (halfHit >= 2)
			{
				cipher = GameObject.Find("result" + number.ToString() + "3");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}
			if (halfHit >= 3)
			{
				cipher = GameObject.Find("result" + number.ToString() + "4");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}

			if (hit >= 2)
			{
				cipher = GameObject.Find("result" + number.ToString() + "2");
				cipher.GetComponent<Renderer>().material.color = Color.black;
				if (halfHit >= 1)
				{
					cipher = GameObject.Find("result" + number.ToString() + "3");
					cipher.GetComponent<Renderer>().material.color = Color.white;
				}
				if (halfHit >= 2)
				{
					cipher = GameObject.Find("result" + number.ToString() + "4");
					cipher.GetComponent<Renderer>().material.color = Color.white;
				}

			}
			if (hit >= 3)
			{
				cipher = GameObject.Find("result" + number.ToString() + "3");
				cipher.GetComponent<Renderer>().material.color = Color.black;
				if (halfHit >= 1)
				{
					cipher = GameObject.Find("result" + number.ToString() + "4");
					cipher.GetComponent<Renderer>().material.color = Color.white;
				}
			}
			if (hit == 4)
			{
				cipher = GameObject.Find("result" + number.ToString() + "4");
				cipher.GetComponent<Renderer>().material.color = Color.black;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
			}
		}
		else
		{
			if (halfHit >= 1)
			{
				cipher = GameObject.Find("result" + number.ToString() + "1");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}
			if (halfHit >= 2)
			{
				cipher = GameObject.Find("result" + number.ToString() + "2");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}
			if (halfHit >= 3)
			{
				cipher = GameObject.Find("result" + number.ToString() + "3");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}
			if (halfHit >= 4)
			{
				cipher = GameObject.Find("result" + number.ToString() + "4");
				cipher.GetComponent<Renderer>().material.color = Color.white;
			}
		}
	}

	/// <summary>
	/// Setting the hidden cipher, displaying messages on the board, counting steps in round
	/// </summary>
	public void changeAllColor()
	{
		if (counter == 0)
		{
			cipher = GameObject.Find("hiddenCipher1");
			randomColorSet();
			cipher.GetComponent<Renderer>().material.color = randomColor;

			cipher = GameObject.Find("hiddenCipher2");
			randomColorSet();
			cipher.GetComponent<Renderer>().material.color = randomColor;

			cipher = GameObject.Find("hiddenCipher3");
			randomColorSet();
			cipher.GetComponent<Renderer>().material.color = randomColor;

			cipher = GameObject.Find("hiddenCipher4");
			randomColorSet();
			cipher.GetComponent<Renderer>().material.color = randomColor;
		}

		child = transform.Find("stepsRound");
		Text t = child.GetComponent<Text>();
		counter = counter + 1;
		t.text = "STEPS IN THIS ROUND: " + counter;
		counter = counter - 1;
		child2 = transform.Find("timeRound");
		Text p = child2.GetComponent<Text>();
		changeColor(counter);
		Debug.Log("compareHalfHit()");
		compareHalfHit();
		Debug.Log("compareHit()");
		compareHit();
		showHit(counter - 1);

		if (counter > 9)
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	/// <summary>
	/// Set the code given by the user in the appriopriate
	/// </summary>
	/// <param name="number">line number on the board</param>
	public void changeColor(int number)
	{
		for (int i = 1; i < 5; i++)
		{
			code = GameObject.Find("code" + number.ToString() + i.ToString());
			code2 = GameObject.Find("cipher" + i.ToString());
			code.GetComponent<Renderer>().material.color = code2.GetComponent<Renderer>().material.color;
		}
		counter++;
	}

	/// <summary>
	/// Counts the number of hits colors in the right position
	/// </summary>
	public void compareHit()
	{
		hit = 0;
		for (int i = 1; i < 5; i++)
		{
			compare = GameObject.Find("hiddenCipher" + i.ToString());
			compare2 = GameObject.Find("cipher" + i.ToString());
			if (compare.GetComponent<Renderer>().material.color == compare2.GetComponent<Renderer>().material.color)
			{
				hit++;
			}
		}
		Debug.Log("Hit: " + hit);
	}


	/// <summary>
	/// Counts the number of right colors on wrong position
	/// </summary>
	public void compareHalfHit()
	{
		halfHit = 0;
		control = new int[4] { 0, 0, 0, 0 };
		control2 = new int[4] { 0, 0, 0, 0 };

		for (int i = 0; i < 4; i++)
		{
			int tmp_i = i + 1;
			for (int j = 0; j < 4; j++)
			{
				int tmp_j = j + 1;
				compare = GameObject.Find("hiddenCipher" + tmp_j.ToString());
				compare2 = GameObject.Find("hiddenCipher" + tmp_i.ToString());
				compare3 = GameObject.Find("cipher" + tmp_j.ToString());
				compare4 = GameObject.Find("cipher" + tmp_i.ToString());
				compareHalf(compare, compare2, compare3, compare4, i, j);
			}
		}


		Debug.Log("Half hit:" + halfHit);

	}
	int[] control;
	int[] control2;


	/// <summary>
	/// Compares ciphers and counts the number of correct color hits that are not in place
	/// </summary>
	/// <param name="compare">colors to compare</param>
	/// <param name="compare2">colors to compare</param>
	/// <param name="compare3">colors to compare</param>
	/// <param name="compare4">colors to compare</param>
	/// <param name="i">temporary variable to fill array</param>
	/// <param name="j">temporary variable to fill array</param>
	public void compareHalf(GameObject compare, GameObject compare2, GameObject compare3, GameObject compare4, int i, int j)
	{

		if (compare4.GetComponent<Renderer>().material.color == compare.GetComponent<Renderer>().material.color)
		{
			if (control[i] == 0 && control2[j] == 0)
			{
				if (i == j)
				{
					control[i] = 1;
					control2[i] = 1;
				}
				else
				{
					if (compare3.GetComponent<Renderer>().material.color != compare.GetComponent<Renderer>().material.color)
					{
						if (compare4.GetComponent<Renderer>().material.color != compare2.GetComponent<Renderer>().material.color)
						{
							control[i] = 1;
							control2[j] = 1;
							halfHit++;
						}
						else
						{
							control[i] = 1;
							control2[i] = 1;
						}
					}
					else
					{
						control[j] = 1;
						control2[j] = 1;
					}
				}
			}
		}
	}
}
