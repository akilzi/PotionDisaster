﻿using UnityEngine;
using System.Collections;

public class TitleSceneController : MonoBehaviour
{

    public GameObject GameManager;
	void Update () 
    {
	    if (Input.anyKeyDown)
	    {
	        GameManager.GetComponent<GameController>().NextState();
	    }
	}
}
