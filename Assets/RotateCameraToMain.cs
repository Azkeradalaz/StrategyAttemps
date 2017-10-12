using UnityEngine;

public class RotateCameraToMain : MonoBehaviour {

	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.rotation = mainCamera.transform.rotation;
	}
}
