using UnityEngine;
using System.Collections;

public class YellowDestroy : MonoBehaviour {

	//public GameObject ThisIsMe;
	public GameObject Bullet;
	public GameObject CountManager;
	public GameObject coins;

	// Use this for initialization
	void Start ()
	{
	    CountManager = GameObject.FindGameObjectWithTag("CountManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter2D(Collision2D node)
	{
		if(Bullet.renderer.sharedMaterial.color == Color.yellow)
		{
			if(node.gameObject.tag == "Bullet")
			{
			    CountManager.GetComponent<CountManager>().removeEnemy(gameObject);
				Instantiate(coins, transform.position, transform.rotation);
			    Destroy(gameObject);
			}
		//instantiate particle effect
		}
	}
}
