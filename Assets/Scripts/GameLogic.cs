using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	//check if the player wins
	public bool didPlayerWin = false;
	//check if the object is the treasue/final door
	public bool isDoor = false;
	//define how far the player has to be from the object before seeing the directional text
	public float maxMagnitude;
	public Text objectText;
	public Transform playerPosition;
	public Transform treasurePosition;
	//define what message is diplayed at one specific pbject
	public string objectMessage = "";
	//display a black panel at the end of the game
	public GameObject panel;
	// Use this for initialization
	void Start () {
		//nothing happens here
	}
	
	// Update is called once per frame
	void Update () {
		//check if the player won
		if (didPlayerWin) {
			//display the winning text
			objectText.text = "YOU WENT THROUGH THE DOOR";
			//activate a black panel to seperate the end from the rest of the game
			panel.SetActive (true);
		//Check where the player is located in relation to the object.
		} else if ((playerPosition.position - treasurePosition.position).magnitude < maxMagnitude) {
			//check if the player is in front of the final game.
			if (isDoor) {
				objectText.text = objectMessage;
				//let the player press space to go through the door
				if (Input.GetKey (KeyCode.Space)) {
					didPlayerWin = true;
				}
			//the player is next to an object that is not the final door.
			} else {
				//Debug.Log ("is player by the house?");
				objectText.text = objectMessage;
			}
		} else {
			//The player is not next to any object and thus no text is displayed.
			objectText.text =  "";
		}
	}
}
