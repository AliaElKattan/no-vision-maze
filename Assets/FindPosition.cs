using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FindPosition : MonoBehaviour {
    private float position = GameObject.Find("MainPlayer").transform.position.z;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (position > 15) {
			SceneManager.LoadScene ("Level2");
		}
	}
}
