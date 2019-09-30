using UnityEngine;
using System.Collections;

public class MainMovement : MonoBehaviour {

    private Rigidbody player;
    public float playerSpeed;


	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0);
            player.AddForce(movement * playerSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 movement = new Vector3(0, 0.0f, moveVertical);
            player.AddForce(movement * playerSpeed);
        }

        else
        {
            Vector3 stop = new Vector3(0.0f, 0.0f, 0.0f);
            player.AddForce(stop);
        }
    }
}
