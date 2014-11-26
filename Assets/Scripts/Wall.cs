using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	public float max_y;
	public float min_y;
	void Update () {
		transform.position = new Vector3 (transform.position.x, Mathf.Clamp (transform.position.y, min_y, max_y), transform.position.z);
	}
}
