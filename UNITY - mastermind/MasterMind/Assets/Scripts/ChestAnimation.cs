using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimation : MonoBehaviour {


	private Animator anim;
	private GameObject chest;
	
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetInteger("zmienna", 1);
		chest = GameObject.Find("treasurechest_open");
	}
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.V))
		{
			this.OpenChest();
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			this.CloseChest();
		}

	}



	public void OpenChest()
	{
		anim.SetInteger("zmienna", 1);
		//anim.Play("Take 001");
	}

	public void CloseChest()
	{
		anim.SetInteger("zmienna", 2);
	}
}
