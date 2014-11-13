using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Tunnel") {
			other.gameObject.SetActive(false);
		} else {
			Destroy (other.gameObject);
		}
	}
}
