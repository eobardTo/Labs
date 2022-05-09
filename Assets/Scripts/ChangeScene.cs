using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScene()
    {
    	SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
    	EscapeDown();
    }
    private void EscapeDown()
    {
    	if (Input.GetKey(KeyCode.Escape) && SceneManager.GetActiveScene().name == "Game")
    	{
    		SceneManager.LoadScene("Menu");
    	}
    }
}
