using UnityEngine;
using System.Collections;

public class GreenDestroy : MonoBehaviour {
	
	public GameObject Bullet;
	public GameObject CountManager;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnCollisionEnter2D(Collision2D node)
	{
		Debug.Log ("deadly bullet");
		if(Bullet.renderer.sharedMaterial.color == Color.green)
		{
			if(node.gameObject.tag == "Bullet")
				CountManager.GetComponent<CountManager>().removeEnemy(gameObject);
				Destroy(gameObject);
			//instantiate particle effect
		}
	}
}
