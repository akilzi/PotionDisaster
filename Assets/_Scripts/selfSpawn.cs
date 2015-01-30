using UnityEngine;
using System.Collections;

public class selfSpawn : MonoBehaviour {
	int i = 0;

	public GameObject Self;

	// Use this for initialization
	void Start () {
		if (i < 3) 
				{
					InvokeRepeating ("Duplicate", 10, 0.3F);
				}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Duplicate()
		{
			while (i < 3) 
				{
				Instantiate(Self, transform.position, transform.rotation);
				i++;
				}
		}
}
