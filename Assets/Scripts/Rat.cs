using UnityEngine;
using System.Collections;

public class Rat : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			transform.position = Vector3.MoveTowards(transform.position, transform.position - new Vector3(1,0,0), Time.deltaTime * 6);
		}
		else if (Input.GetKey(KeyCode.D)) {
			transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(1,0,0), Time.deltaTime * 6);
		}
		//controls for jumping
		if (Input.GetKeyDown(KeyCode.W)) {
			gameObject.rigidbody.AddForce(new Vector3(0,600.0f,0));
			
		}
	}
}
