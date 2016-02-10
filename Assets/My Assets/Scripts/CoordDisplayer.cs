using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoordDisplayer : MonoBehaviour {

	public GameObject obj;
	Transform objTransform;
	Text myText;

	// Use this for initialization
	void Start () {
		objTransform = obj.GetComponent<Transform>();
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "(" + Mathf.Round(objTransform.position.x).ToString() + ", " + Mathf.Round(objTransform.position.z).ToString() + ")";
	}
}
