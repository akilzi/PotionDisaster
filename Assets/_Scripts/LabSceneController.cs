﻿using UnityEngine;
using System.Collections;

public class LabSceneController : MonoBehaviour
{

    private GameController _gameController;
	void Start ()
	{
	    _gameController = GameObject.Find("GameManager").GetComponent<GameController>();

	    if (_gameController.CharacterType == CharacterOptions.GUNNER)
	    {
            //GameObject.FindGameObjectWithTag("RedButton").GetComponent<Button>().enabled = false;
            //GameObject.FindGameObjectWithTag("BlueButton").GetComponent<Button>().enabled = false;
            //GameObject.FindGameObjectWithTag("YellowButton").GetComponent<Button>().enabled = false;
            //GameObject.FindGameObjectWithTag("MixButton").GetComponent<Button>().enabled = false;
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
