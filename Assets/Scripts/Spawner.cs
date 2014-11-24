using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {
	List<GameObject> segmentPool;
	void Start () {
		segmentPool = new List<GameObject>();
		// Array of map segments
		GameObject[] segmentArray = new GameObject[] {
			(GameObject)Resources.Load ("Prefabs/Segment_Blank"),
			(GameObject)Resources.Load ("Prefabs/Segment_Wall_Up"),
			(GameObject)Resources.Load ("Prefabs/Segment_Wall_Down")
		};
		GameObject segment;
		// for each segment type
		for (int i = 0; i < segmentArray.Length; i++) {
			// instantiate x number of segments
			for (int j = 0; j < 5; j++) {
				segment = (GameObject)Instantiate (segmentArray[i]);
				segment.SetActive (false);
				segmentPool.Add (segment);
			}
		}
	}
	
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Segment" || other.gameObject.tag == "SegmentStart") {
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
