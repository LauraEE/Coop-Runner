using UnityEngine;
using System.Collections;

public class Tunnel : MonoBehaviour {
	public float levelSpeed = 0.1f;
	void Update () {
		float currentX = transform.position.x;
		float currentY = transform.position.y;
		Vector3 target = new Vector3 (currentX - levelSpeed, currentY, 0);
		transform.position = Vector3.MoveTowards (transform.position, target, 1.0f); 
	}
}
