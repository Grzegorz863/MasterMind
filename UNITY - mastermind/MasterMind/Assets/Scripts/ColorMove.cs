using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class is responsible for moving colors
/// </summary>
public class ColorMove : MonoBehaviour {

	public SpringJoint2D springJoint;

	/// <summary>
	/// Awake is used to initialize any variables or game state before the game starts
	/// </summary>
	void Awake()
	{
		springJoint = this.gameObject.GetComponent<SpringJoint2D>(); 
		springJoint.connectedAnchor = gameObject.transform.position;
	}

	/// <summary>
	/// On click
	/// </summary>
	void OnMouseDown()
	{
		springJoint.enabled = true;
	}

	/// <summary>
	/// On release
	/// </summary>
	void OnMouseDrag()        
	{
		if (springJoint.enabled = true) 
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			springJoint.connectedAnchor = cursorPosition;
		}
	}
}
