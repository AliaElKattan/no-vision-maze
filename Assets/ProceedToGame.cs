using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ProceedToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Space) || Input.GetKeyUp (KeyCode.JoystickButton0) || Input.GetKeyUp (KeyCode.JoystickButton1) || Input.GetKeyUp (KeyCode.JoystickButton2) || Input.GetKeyUp (KeyCode.JoystickButton3) || Input.GetKeyUp (KeyCode.JoystickButton4)) {
			SceneManager.LoadScene ("Level1");
		}
	}
}
