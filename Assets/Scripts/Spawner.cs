using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {
	List<GameObject> segmentPool;
	// Use this for initialization
	void Start () {
		segmentPool = new List<GameObject>();
		GameObject segment1 = (GameObject)Resources.Load ("Prefabs/Tunnel_01");
		GameObject segment;
		for (int i = 0; i < 10; i++) {
			segment = (GameObject)Instantiate (segment1);
			segment.SetActive (false);
			segmentPool.Add (segment);
		}
		
	}
	
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Tunnel" || other.gameObject.tag == "StartTunnel") {
			foreach (GameObject s in segmentPool) {
				int nextSegment = Random.Range(0, segmentPool.Count);
				if (!segmentPool[nextSegment].activeInHierarchy) {
					segmentPool[nextSegment].transform.position = other.transform.position + new Vector3 (10,0,0);
					segmentPool[nextSegment].SetActive (true);
					break;
				}
			}
		}
	}
}
