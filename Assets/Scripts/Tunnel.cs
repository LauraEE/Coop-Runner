using UnityEngine;
using System.Collections;

public class Tunnel : MonoBehaviour {
	float levelSpeed = 0.1f;
	void Update () {
		float position_x = transform.position.x;
		float position_y = transform.position.y;
		Vector3 target = new Vector3 (position_x - levelSpeed, position_y, 0);
		transform.position = Vector3.MoveTowards (transform.position, target, 1.0f); 
	}
}
