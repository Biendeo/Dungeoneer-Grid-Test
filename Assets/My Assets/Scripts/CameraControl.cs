using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public float defaultSpeed = 1.0f;
	public float fastSpeed = 3.0f;
	Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		float speed = defaultSpeed;
		if (Input.GetAxis("Run") > 0) {
			speed = fastSpeed;
		}

		// Play around with the Input gravity to get a good feel.
		myTransform.position += Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical");
		myTransform.position += Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal");
	}
}
