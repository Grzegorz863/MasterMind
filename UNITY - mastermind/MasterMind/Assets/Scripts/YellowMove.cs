using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for moving yellow color
/// </summary>
[RequireComponent(typeof(BoxCollider))]
public class YellowMove : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;
	float x;
	float y;
	float z;

	/// <summary>
	/// The begining function
	/// </summary>
	/// <remarks>Start is called one time on the begining</remarks>
	void Start()
	{
		x = gameObject.transform.position.x;
		y = gameObject.transform.position.y;
		z = gameObject.transform.position.z;
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		if (Input.GetMouseButtonUp (0))
			transform.position = new Vector3 (x, y, z);
	}

	/// <summary>
	/// Catching the shape with color
	/// </summary>
	void OnMouseDown()
	{
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	/// <summary>
	/// Dropping the shape with color
	/// </summary>
	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}

	/// <summary>
	/// Collision detection
	/// </summary>
	/// <remarks>Collosion is detected after meeting 2 shapes</remarks>
	/// <param name="collision">object of collider</param>
	void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}

