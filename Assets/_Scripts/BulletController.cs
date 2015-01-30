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
	    StartCoroutine(TTL());

        if (renderer.sharedMaterial.color == Color.white)
        {
            renderer.sharedMaterial.color = _potionCombinations.SelectedColor;
        }
	}
	
	void Update () 
    {
	    

	    if (gameObject.activeSelf)
	    {
            if (!float.IsNaN(forceVector.x))
            {
                rigidbody2D.AddForce(forceVector);
            }

            forceVector = shortenLength(forceVector, 100);
	    }
    }

    Vector3 shortenLength(Vector3 vector, float reductionLength)
    {
        Vector3 b = vector;
        b *= (1 - reductionLength / vector.magnitude);
        return b;
    }

    IEnumerator TTL()
    {
        for (float timer = .6f; timer >= 0; timer -= Time.deltaTime)
            yield return 0;

        Destroy(gameObject);
    }
}
