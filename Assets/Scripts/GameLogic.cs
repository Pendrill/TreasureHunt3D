using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public bool didPlayerWin = false;
	public bool isDoor = false;
	public float maxMagnitude;
	public Text objectText;
	public Transform playerPosition;
	public Transform treasurePosition;
	public string objectMessage = "";
	public GameObject panel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (didPlayerWin) {
			objectText.text = "YOU WENT THROUGH THE DOOR";
			panel.SetActive (true);
		} else if ((playerPosition.position - treasurePosition.position).magnitude < maxMagnitude) {
			if (isDoor) {
				objectText.text = objectMessage;
				if (Input.GetKey (KeyCode.Space)) {
					didPlayerWin = true;
				}
			} else {
				//Debug.Log ("is player by the house?");
				objectText.text = objectMessage;
			}
		} else {
			objectText.text =  "";
		}
	}
}
