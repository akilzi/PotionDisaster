using UnityEngine;
using System.Collections;

public class RedDestroy : MonoBehaviour {
	
	public GameObject Bullet;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter2D(Collision2D node)
	{
		if(Bullet.renderer.sharedMaterial.color == Color.red)
		{
			if(node.gameObject.tag == "Bullet")
				Destroy(gameObject);
			//instantiate particle effect
		}
	}
}
