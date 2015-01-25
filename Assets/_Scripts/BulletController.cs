using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public Vector3 forceVector;
    private GameObject _potionLogic;
    private PotionCombinations _potionCombinations;

	void Start ()
	{
	    _potionLogic = GameObject.FindGameObjectWithTag("PotionLogic");
	    _potionCombinations = _potionLogic.GetComponent<PotionCombinations>();
	    renderer.sharedMaterial.color = _potionCombinations.SelectedColor;
	}
	
	void Update () 
    {
	    if (renderer.sharedMaterial.color == Color.white)
	    {
            renderer.sharedMaterial.color = _potionCombinations.SelectedColor;
	    }

	    if (gameObject.activeSelf)
	    {
            //if (!float.IsNaN(forceVector.x))
            //{
            //    rigidbody2D.AddForce(forceVector);
            //}

            //forceVector = shortenLength(forceVector, 1000);
	    }
    }

    Vector3 shortenLength(Vector3 vector, float reductionLength)
    {
        Vector3 b = vector;
        b *= (1 - reductionLength / vector.magnitude);
        return b;
    }
}
