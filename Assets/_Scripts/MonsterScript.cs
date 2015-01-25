using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterScript : MonoBehaviour {
	
	//public GameObject ThisIsMe;
	public GameObject CountManager;
	
	// Use this for initialization
	void Start () {
		TribbleEffect ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void TribbleEffect() {
		InvokeRepeating("InstantiateMe", 5, 5);
	}
	
	void InstantiateMe()
	{
		Instantiate (gameObject);
		CountManager.GetComponent<CountManager>().addEnemy(gameObject);
	}
}