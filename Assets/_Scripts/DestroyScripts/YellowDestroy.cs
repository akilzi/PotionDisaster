using UnityEngine;
using System.Collections;

public class YellowDestroy : MonoBehaviour {

	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter2D(Collision2D node)
	{
		Debug.Log ("deadly bullet");
		if(Bullet.renderer.sharedMaterial.color == Color.yellow)
		{
			if(node.gameObject.tag == "Bullet")
			Destroy(gameObject);
		//instantiate particle effect
		}
	}
}
