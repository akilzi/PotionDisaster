﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LabSceneController : MonoBehaviour
{

    private GameObject _characterSelect;
	void Start ()
	{
	    _characterSelect = GameObject.Find("CharacterSelect");

	    if (_characterSelect.GetComponent<CharacterSelect>().isGunner)
	    {
	        GameObject.FindGameObjectWithTag("RedButton").GetComponent<Button>().enabled = false;
            GameObject.FindGameObjectWithTag("BlueButton").GetComponent<Button>().enabled = false;
            GameObject.FindGameObjectWithTag("YellowButton").GetComponent<Button>().enabled = false;
            GameObject.FindGameObjectWithTag("MixButton").GetComponent<Button>().enabled = false;
	    }

	    GameObject monster = PhotonNetwork.Instantiate("BlueIce_WeakToRed", Vector3.zero, Quaternion.identity, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
