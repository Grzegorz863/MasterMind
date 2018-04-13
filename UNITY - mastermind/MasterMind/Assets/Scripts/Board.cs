using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Board : MonoBehaviour {

	GameObject enemy;
	GameObject enemy2;
	GameObject compare;
	GameObject compare2;
	GameObject compare3;
	GameObject compare4;
	Transform child;
	Transform child2;
	int counter=0;
	int hit=0;
	int halfHit=0;

	private float timer = 0;

	void UpdateTime() 
	{
		timer += Time.deltaTime;
		Debug.Log(timer);
	}

	public void QuitGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +1 );
	}

	public void NewGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	GameObject cipher;
	Color randomColor;

	void randomColorSet(){
		int number= Random.Range(1,7);
		if (number == 1) {
			randomColor = Color.cyan;
		}
		if (number == 2) {
			randomColor = Color.green;
		}
		if (number == 3) {
			randomColor = Color.white;
		}
		if (number == 4) {
			randomColor = Color.red;
		}
		if (number == 5) {
			randomColor = Color.yellow;
		}
		if (number == 6) {
			randomColor = Color.magenta;
		}
	}

	public void showHit0()
	{
		Debug.Log ("showhint0");
		if (hit >= 1) {
			cipher = GameObject.Find ("result01");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result02");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result03");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result04");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result02");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result03");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result04");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			
			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result03");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result04");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result04");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			} 
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result01");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result02");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result03");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result04");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit1()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result11");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result12");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result13");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result14");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result12");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result13");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result14");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result13");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result14");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result14");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result11");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result12");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result13");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result14");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit2()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result21");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result22");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result23");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result24");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result22");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result23");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result24");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result23");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result24");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result24");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result21");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result22");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result23");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result24");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit3()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result31");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result32");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result33");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result34");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result32");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result33");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result34");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result33");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result34");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result34");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result31");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result32");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result33");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result34");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit4()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result41");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result42");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result43");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result44");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result42");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result43");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result44");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result43");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result44");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result44");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result41");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result42");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result43");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result44");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}
	

	public void showHit5()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result51");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result52");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result53");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result54");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result52");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result53");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result54");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result53");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result54");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result54");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result51");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result52");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result53");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result54");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit6()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result61");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result62");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result63");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result64");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result62");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result63");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result64");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result63");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result64");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result64");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result61");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result62");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result63");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result64");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit7()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result71");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result72");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result73");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result74");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result72");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result73");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result74");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result73");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result74");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result74");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result71");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result72");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result73");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result74");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit8()
	{

		if (hit >= 1) {
			cipher = GameObject.Find ("result81");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result82");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result83");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result84");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result82");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result83");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result84");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result83");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result84");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result84");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result81");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result82");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result83");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result84");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void showHit9()
	{
		if (hit >= 1) {
			cipher = GameObject.Find ("result91");
			cipher.GetComponent<Renderer> ().material.color = Color.black;
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result92");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result93");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result94");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		
			if (hit >= 2) {
				cipher = GameObject.Find ("result92");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result93");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
				if (halfHit >= 2) {
					cipher = GameObject.Find ("result94");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}

			}
			if (hit >= 3) {
				cipher = GameObject.Find ("result93");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				if (halfHit >= 1) {
					cipher = GameObject.Find ("result94");
					cipher.GetComponent<Renderer> ().material.color = Color.white;
				}
			}
			if (hit == 4) {
				cipher = GameObject.Find ("result94");
				cipher.GetComponent<Renderer> ().material.color = Color.black;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +2 );
			}
		} else {
			if (halfHit >= 1) {
				cipher = GameObject.Find ("result91");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 2) {
				cipher = GameObject.Find ("result92");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 3) {
				cipher = GameObject.Find ("result93");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
			if (halfHit >= 4) {
				cipher = GameObject.Find ("result94");
				cipher.GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}

	public void changeAllColor(){
		
		
		if (counter == 0) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			cipher = GameObject.Find ("hiddenCipher1");
			randomColorSet ();
			cipher.GetComponent<Renderer> ().material.color = randomColor;

			cipher = GameObject.Find ("hiddenCipher2");
			randomColorSet ();
			cipher.GetComponent<Renderer> ().material.color = randomColor;

			cipher = GameObject.Find ("hiddenCipher3");
			randomColorSet ();
			cipher.GetComponent<Renderer> ().material.color = randomColor;

			cipher = GameObject.Find ("hiddenCipher4");
			randomColorSet ();
			cipher.GetComponent<Renderer> ().material.color = randomColor;

			changeColor0 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit0 ();
		} else if (counter == 1) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor1 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit1 ();
		} else if (counter == 2) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor2 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit2 ();
		} else if (counter == 3) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor3 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit3 ();
		} else if (counter == 4) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor4 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit4 ();
		} else if (counter == 5) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor5 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit5 ();
		} else if (counter == 6) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor6 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit6 ();
		} else if (counter == 7) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor7 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit7 ();
		} else if (counter == 8) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor8 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit8 ();
		} else if (counter == 9) {
			child = transform.Find ("stepsRound");
			Text t = child.GetComponent<Text> ();
			t.text = "STEPS IN THIS ROUND: " + counter + 1;
			child2 = transform.Find ("timeRound");
			Text p = child2.GetComponent<Text> ();
			UpdateTime ();
			p.text = "TIME IN THIS ROUND: " + timer;
			changeColor9 ();
			Debug.Log ("compareHalfHit()");
			compareHalfHit ();
			Debug.Log ("compareHit()");
			compareHit ();
			showHit9 ();
		} else if (counter > 9) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex +1 );
		}
	}

	public void changeColor0(){
		enemy = GameObject.Find("code01");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code02");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code03");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code04");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor1(){
		enemy = GameObject.Find("code11");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code12");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code13");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code14");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor2(){
		enemy = GameObject.Find("code21");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code22");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code23");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code24");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor3(){
		enemy = GameObject.Find("code31");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code32");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code33");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code34");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor4(){
		enemy = GameObject.Find("code41");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code42");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code43");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code44");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor5(){
		enemy = GameObject.Find("code51");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code52");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code53");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code54");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor6(){
		enemy = GameObject.Find("code61");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code62");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code63");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code64");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor7(){
		enemy = GameObject.Find("code71");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code72");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code73");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code74");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor8(){
		enemy = GameObject.Find("code81");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code82");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code83");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code84");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void changeColor9(){
		enemy = GameObject.Find("code91");
		enemy2 = GameObject.Find ("cipher1");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code92");
		enemy2 = GameObject.Find ("cipher2");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code93");
		enemy2 = GameObject.Find ("cipher3");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;

		enemy = GameObject.Find("code94");
		enemy2 = GameObject.Find ("cipher4");
		enemy.GetComponent<Renderer>().material.color = enemy2.GetComponent<Renderer>().material.color;
		counter++;
	}

	public void compareHit()
	{
		hit = 0;

		compare = GameObject.Find("hiddenCipher1");
		compare2 = GameObject.Find ("cipher1");
		if (compare.GetComponent<Renderer>().material.color == compare2.GetComponent<Renderer>().material.color)
		{
			hit++;
		}
		compare = GameObject.Find("hiddenCipher2");
		compare2 = GameObject.Find ("cipher2");
		if (compare.GetComponent<Renderer>().material.color == compare2.GetComponent<Renderer>().material.color)
		{
			hit++;
		}
		compare = GameObject.Find("hiddenCipher3");
		compare2 = GameObject.Find ("cipher3");
		if (compare.GetComponent<Renderer>().material.color == compare2.GetComponent<Renderer>().material.color)
		{
			hit++;
		}
		compare = GameObject.Find("hiddenCipher4");
		compare2 = GameObject.Find ("cipher4");
		if (compare.GetComponent<Renderer>().material.color == compare2.GetComponent<Renderer>().material.color)
		{
			hit++;
		}

		Debug.Log ("Hit: " + hit);
	}


	public void compareHalfHit()
	{
		halfHit = 0;
		int i = 0, j = 0;
		control = new int[4]{0,0,0,0};
		control2 = new int[4]{0,0,0,0};


		compare = GameObject.Find ("hiddenCipher1");
		compare2 = GameObject.Find ("hiddenCipher1");
		compare3  = GameObject.Find ("cipher1");
		compare4 = GameObject.Find ("cipher1");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 0;
		j = 1;
		compare = GameObject.Find ("hiddenCipher2");
		compare2 = GameObject.Find ("hiddenCipher1");
		compare3  = GameObject.Find ("cipher2");
		compare4 = GameObject.Find ("cipher1");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 0;
		j = 2;
		compare = GameObject.Find ("hiddenCipher3");
		compare2 = GameObject.Find ("hiddenCipher1");
		compare3  = GameObject.Find ("cipher3");
		compare4 = GameObject.Find ("cipher1");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 0;
		j = 3;
		compare = GameObject.Find ("hiddenCipher4");
		compare2 = GameObject.Find ("hiddenCipher1");
		compare3  = GameObject.Find ("cipher4");
		compare4 = GameObject.Find ("cipher1");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 1;
		j = 0;
		compare = GameObject.Find ("hiddenCipher1");
		compare2 = GameObject.Find ("hiddenCipher2");
		compare3  = GameObject.Find ("cipher1");
		compare4 = GameObject.Find ("cipher2");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 1;
		j = 1;
		compare = GameObject.Find ("hiddenCipher2");
		compare2 = GameObject.Find ("hiddenCipher2");
		compare3  = GameObject.Find ("cipher2");
		compare4 = GameObject.Find ("cipher2");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 1;
		j = 2;
		compare = GameObject.Find ("hiddenCipher3");
		compare2 = GameObject.Find ("hiddenCipher2");
		compare3  = GameObject.Find ("cipher3");
		compare4 = GameObject.Find ("cipher2");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 1;
		j = 3;
		compare = GameObject.Find ("hiddenCipher4");
		compare2 = GameObject.Find ("hiddenCipher2");
		compare3  = GameObject.Find ("cipher4");
		compare4 = GameObject.Find ("cipher2");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 2;
		j = 0;
		compare = GameObject.Find ("hiddenCipher1");
		compare2 = GameObject.Find ("hiddenCipher3");
		compare3  = GameObject.Find ("cipher1");
		compare4 = GameObject.Find ("cipher3");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 2;
		j = 1;
		compare = GameObject.Find ("hiddenCipher2");
		compare2 = GameObject.Find ("hiddenCipher3");
		compare3  = GameObject.Find ("cipher2");
		compare4 = GameObject.Find ("cipher3");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 2;
		j = 2;
		compare = GameObject.Find ("hiddenCipher3");
		compare2 = GameObject.Find ("hiddenCipher3");
		compare3  = GameObject.Find ("cipher3");
		compare4 = GameObject.Find ("cipher3");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 2;
		j = 3;
		compare = GameObject.Find ("hiddenCipher4");
		compare2 = GameObject.Find ("hiddenCipher3");
		compare3  = GameObject.Find ("cipher4");
		compare4 = GameObject.Find ("cipher3");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 3;
		j = 0;
		compare = GameObject.Find ("hiddenCipher1");
		compare2 = GameObject.Find ("hiddenCipher4");
		compare3  = GameObject.Find ("cipher1");
		compare4 = GameObject.Find ("cipher4");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 3;
		j = 1;
		compare = GameObject.Find ("hiddenCipher2");
		compare2 = GameObject.Find ("hiddenCipher4");
		compare3  = GameObject.Find ("cipher2");
		compare4 = GameObject.Find ("cipher4");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 3;
		j = 2;
		compare = GameObject.Find ("hiddenCipher3");
		compare2 = GameObject.Find ("hiddenCipher4");
		compare3  = GameObject.Find ("cipher3");
		compare4 = GameObject.Find ("cipher4");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		i = 3;
		j = 3;
		compare = GameObject.Find ("hiddenCipher4");
		compare2 = GameObject.Find ("hiddenCipher4");
		compare3  = GameObject.Find ("cipher4");
		compare4 = GameObject.Find ("cipher4");
		compareHalf (compare, compare2, compare3, compare4, i, j);

		Debug.Log ("Half hit:" + halfHit);
				
	}
	int[] control;
	int[] control2;

	public void compareHalf(GameObject compare, GameObject compare2, GameObject compare3, GameObject compare4, int i, int j){
		
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
