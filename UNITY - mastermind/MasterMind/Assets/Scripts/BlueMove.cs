using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class BlueMove : MonoBehaviour {

	private Vector3 screenPoint;
	private Vector3 offset;
	private Vector3 curScreenPoint;
	float x;
	float y;
	float z;

	void Start(){
		x = gameObject.transform.position.x;
		y = gameObject.transform.position.y;
		z = gameObject.transform.position.z;

	}

	void Update(){
		if (Input.GetMouseButtonUp (0)) {
			transform.position = new Vector3 (x, y, z);
		}
	}

	void OnMouseDown() {
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseDrag()
	{
		curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}


	void OnTriggerEnter(Collider collision) {
        // Tutaj kod wykonywany po wykryciu kolizji
        collision.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
		transform.position = curScreenPoint;
	}

}
