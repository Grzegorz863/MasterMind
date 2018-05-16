using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The class responsible for chest animation
/// </summary>
public class ChestAnimation : MonoBehaviour {


	private Animator anim;
	private GameObject chest;

	/// <summary>
	/// The begining function
	/// </summary>
	/// <remarks>Start is called one time on begining</remarks>
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetInteger("zmienna", 1);
		chest = GameObject.Find("treasurechest_open");
	}


	/// <summary>
	/// Update is called once per frame
	/// </summary>
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


	/// <summary>
	/// Open the chest
	/// </summary>
	public void OpenChest()
	{
		anim.SetInteger("zmienna", 1);
	}

	/// <summary>
	/// Close the chest
	/// </summary>
	public void CloseChest()
	{
		anim.SetInteger("zmienna", 2);
	}
}
