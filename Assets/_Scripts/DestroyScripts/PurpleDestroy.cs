﻿using UnityEngine;
using System.Collections;

public class PurpleDestroy : MonoBehaviour {
	
	public GameObject Bullet;
	public GameObject CountManager;
	
	// Use this for initialization
	void Start () {
        CountManager = GameObject.FindGameObjectWithTag("CountManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter2D(Collision2D node)
	{
		if(Bullet.renderer.sharedMaterial.color == Color.magenta)
		{
		    if (node.gameObject.tag == "Bullet")
		    {
		        CountManager.GetComponent<CountManager>().removeEnemy(gameObject);
		        Destroy(gameObject);
		    }
		    //instantiate particle effect
		}
	}
}
