using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextLevel : MonoBehaviour
{
	Scene currentScene =  SceneManager.GetActiveScene();
    // Use this for initialization


    void OnTriggerEnter(Collider other)
    {
        if (currentScene.name == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }

        if (currentScene.name == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }

    }

}
