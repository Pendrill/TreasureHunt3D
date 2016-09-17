using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	//We set up a Vector3 to take care of the CameraOffSet
	public Vector3 CameraOffSet;
	//public bool isForward=true;
	char lastButtonPressed;
	// Use this for initialization
	void Start () {
		//We set the offset to 0 at the start
		CameraOffSet = new Vector3 (0, 0, 0);
		lastButtonPressed = 'w';
	}
	
	// Update is called once per frame
	void Update () {
		//The player can use WASD and the Arrow Keys to more the player character around
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			
			if (lastButtonPressed == 'a') {
				transform.eulerAngles += new Vector3 (0, 180, 0);
			} else if (lastButtonPressed == 'w') {
				transform.eulerAngles += new Vector3 (0, 90, 0);
			} else if (lastButtonPressed == 's') {
				transform.eulerAngles += new Vector3 (0, -90, 0);
			}

			//The use of transform.Translate will affect the player movement at a local scale rather than a global one
			transform.Translate (0f, 0f,10f * Time.deltaTime);
			lastButtonPressed = 'd';
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {

			if (lastButtonPressed == 'd') {
				transform.eulerAngles += new Vector3 (0, 180, 0);
			} else if (lastButtonPressed == 'w') {
				transform.eulerAngles += new Vector3 (0, -90, 0);
			} else if (lastButtonPressed == 's') {
				transform.eulerAngles += new Vector3 (0, 90, 0);
			}

			transform.Translate (0f, 0f,10f * Time.deltaTime);
			lastButtonPressed = 'a';
		}
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			//We check if the player is facing forward
			/*if (!isForward) {
				//if not, then we rotate the player 180 degrees so that the player is facing "forward".
				transform.eulerAngles += new Vector3 (0, 180, 0);
				isForward = true;
			}*/

			if (lastButtonPressed == 's') {
				transform.eulerAngles += new Vector3 (0, 180, 0);
			} else if (lastButtonPressed == 'a') {
				transform.eulerAngles += new Vector3 (0, 90, 0);
			} else if (lastButtonPressed == 'd') {
				transform.eulerAngles += new Vector3 (0, -90, 0);
			}

			transform.Translate (0,0,10*Time.deltaTime);
			lastButtonPressed = 'w';
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			//We check if the player is facing forward
			/*if (isForward) {
				//if they are we raotate them 180 degrees again so that they are again facing forwards
				transform.eulerAngles += new Vector3 (0, -180, 0);
				isForward = false;
			}*/

			if (lastButtonPressed == 'w') {
				transform.eulerAngles += new Vector3 (0, 180, 0);
			} else if (lastButtonPressed == 'a') {
				transform.eulerAngles += new Vector3 (0, -90, 0);
			} else if (lastButtonPressed == 'd') {
				transform.eulerAngles += new Vector3 (0, 90, 0);
			}

			transform.Translate (0,0,10*Time.deltaTime);
			lastButtonPressed = 's';
		}
		//The player can use the E and Q or Delete and Left Shift to rotate the player (ie. change where they are facing)
		if (Input.GetKey (KeyCode.E) || Input.GetKey (KeyCode.PageDown)) {
			transform.eulerAngles += new Vector3 (0, 5, 0);
		}
		if (Input.GetKey (KeyCode.Q) || Input.GetKey (KeyCode.RightShift)) {
			transform.eulerAngles += new Vector3 (0, -5, 0);
		}
	}
}
