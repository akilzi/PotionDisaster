using HutongGames.PlayMaker.Actions;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public Vector3 forceVector;
    private GameObject _potionLogic;

	void Start ()
	{
	    _potionLogic = GameObject.FindGameObjectWithTag("PotionLogic");
	    PotionCombinations potionCombinations = _potionLogic.GetComponent<PotionCombinations>();
	    renderer.sharedMaterial.color = potionCombinations.SelectedColor;
	}
	
	void Update () 
    {
	    if (gameObject.activeSelf)
	    {
	        if (!float.IsNaN(forceVector.x))
	        {
                rigidbody2D.AddForce(forceVector);
	        }

	        forceVector = shortenLength(forceVector, 1000);
	    }
    }

    Vector3 shortenLength(Vector3 vector, float reductionLength)
    {
        Vector3 b = vector;
        b *= (1 - reductionLength / vector.magnitude);
        return b;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
