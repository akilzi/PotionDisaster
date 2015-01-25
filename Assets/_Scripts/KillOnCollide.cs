using UnityEngine;
using System.Collections;

public class KillOnCollide : MonoBehaviour {

void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Wall")
		{
			Destroy(gameObject);
		}
	}
}
