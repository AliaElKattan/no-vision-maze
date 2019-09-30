using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Collision col;
    // private int count = 0;
    //public Text score;

    // Use this for initialization
    void Start()
    {
        //     score = GetComponent<Text>();
        rb = GetComponent<Rigidbody>();

    }

    void CollisionTester(Collision col)
    {

        if (col.gameObject.name == "FinishLine" || col.gameObject.name == "Sphere")
        {
            SceneManager.LoadScene("Level2");
        }

    }

    /*  void OnCollisionEnter(Collision col)
      {
          score.text = "Score: 0";
          if (col.gameObject.name == "Cube" || col.gameObject.name == "Wall1" || col.gameObject.name == "Wall2")
          {
              count = count + 1;
              score.text = "Score: " + count;
          }
      }*/

    /* public void finalCollision(Collision col)
     {
         if (col.gameObject.name == "FinishLine")
         {
             SceneManager.LoadScene("Level2");
         }
     }*/

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");



        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0);
            rb.AddForce(movement * speed);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 movement = new Vector3(0, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
        }

        else
        {
            Vector3 stop = new Vector3(0, 0, 0);
            rb.AddForce(stop);
        }


        
    }
}

