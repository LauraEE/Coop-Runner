using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	void OnTriggerExit (Collider other) {
		switch (other.gameObject.tag) {
			case "Segment":
				other.gameObject.SetActive(false);
				break;
			case "SegmentStart":
				Destroy (other.gameObject);
				break;
			case "Wall":
				Vector3 wallPosition = other.transform.position;
				other.transform.position = new Vector3 (wallPosition.x, 0, wallPosition.z);
				break;
		}
	}
}
