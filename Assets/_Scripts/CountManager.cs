using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CountManager : MonoBehaviour {
	
	
	public List<GameObject> totalEnemies;
	public int totalEnemiesInt = 2;
	public GameObject GameManager;
	
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		
		if(totalEnemiesInt >= 80)
		{
			GameManager.GetComponent<GameController>().NextState();

		}
		
	}
	
	public void addEnemy(GameObject enemy)
		
	{
		totalEnemiesInt ++;
	}
	
	public void removeEnemy(GameObject enemy)
		
	{
		totalEnemiesInt --;
	}
}
