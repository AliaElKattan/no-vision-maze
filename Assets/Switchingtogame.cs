﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Switchingtogame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1");
        }
	}
}
