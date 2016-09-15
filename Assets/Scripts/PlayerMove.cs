using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public Vector3 playerPosition;
	public Vector3 CameraOffSet;
	// Use this for initialization
	void Start () {
		playerPosition = transform.position;
		CameraOffSet = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			//playerPosition += new Vector3 (10, 0, 0) * Time.deltaTime; 
			transform.Translate (10f * Time.deltaTime, 0f,0f);
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			//playerPosition += new Vector3 (-10, 0, 0) * Time.deltaTime; 
			transform.Translate (-10f * Time.deltaTime, 0f,0f);
		}
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			//playerPosition += new Vector3 (0, 0, 10) * Time.deltaTime; 
			transform.Translate (0,0,10*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			//playerPosition += new Vector3 (0, 0, -10) * Time.deltaTime;
			transform.Translate (0,0,-10*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.E) || Input.GetKey (KeyCode.PageDown)) {
			transform.eulerAngles += new Vector3 (0, 5, 0);
		}
		if (Input.GetKey (KeyCode.Q) || Input.GetKey (KeyCode.RightShift)) {
			transform.eulerAngles += new Vector3 (0, -5, 0);
		}
		//transform.position = playerPosition;
	}
}
