using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMove : MonoBehaviour {

	public SpringJoint2D springJoint;

	/// <summary>
	/// 
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
