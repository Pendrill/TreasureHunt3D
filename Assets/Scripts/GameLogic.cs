using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public bool didPlayerWin = false;
	public Text objectText;
	public Transform playerPosition;
	public Transform treasurePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (didPlayerWin) {
			objectText.text = "YOU GOT TREASURE AND YOU WIN";
		} else if ((playerPosition.position - treasurePosition.position).magnitude < 5f) {
			objectText.text = "Press [SPACE] to get treasure!";
			if (Input.GetKey (KeyCode.Space)) {
				didPlayerWin = true;
			}
		} else {
			objectText.text =  "";
		}
	}
}
