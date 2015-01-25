using UnityEngine;
using System.Collections;

public class EndSceneController : MonoBehaviour
{

    public GameObject GameManager;
	// Use this for initialization
	void Start ()
	{
	    GameManager = GameObject.FindWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetKeyDown(KeyCode.Y))
	    {
	        GameManager.GetComponent<GameController>().NextState();
	    }
	    if(Input.GetKeyDown(KeyCode.N))
	    {
	        Application.Quit();
	    }
	}
}
