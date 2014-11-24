using UnityEngine;
using System.Collections;

public class Overseer : MonoBehaviour {
	bool moveWall = false;
	GameObject target;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hitInfo;
			Ray raycastOrigin = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast(raycastOrigin, out hitInfo)) {
				if (hitInfo.collider.tag == "Wall") {
					target = hitInfo.collider.gameObject;
					moveWall = true;
				}
			}
		}
		if (Input.GetMouseButton (0) && moveWall) {
			Vector3 inputVect = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
			Vector3 worldPoint = Camera.main.ScreenToWorldPoint(inputVect);
			worldPoint.x = target.transform.position.x;
			worldPoint.z = target.transform.position.z;
			target.transform.position = worldPoint;
		} else {
			moveWall = false;
		}
	}
}
