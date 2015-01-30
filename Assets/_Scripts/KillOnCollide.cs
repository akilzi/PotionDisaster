using UnityEngine;
using System.Collections;

public class KillOnCollide : MonoBehaviour {

    void Start ()

	{
		Die ();
	}

	//void OnCollisionEnter2D(Collision2D col)
	//{
	//	if(col.gameObject.tag == "Wall")
		//{
       //     StartCoroutine(Die());
       // }
    //}

    IEnumerator Die()
    {
        for (float timer = .01f; timer >= 0; timer -= Time.deltaTime)
            yield return 0;

        Destroy(gameObject);
    }
}
