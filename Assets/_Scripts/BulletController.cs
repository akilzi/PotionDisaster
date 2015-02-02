using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public Vector3 forceVector;
    public EntityColor BulletColor;
    
    private GameObject _potionLogic;
    private PotionCombinations _potionCombinations;
    

	void Start ()
	{
	    _potionLogic = GameObject.FindGameObjectWithTag("PotionLogic");
	    _potionCombinations = _potionLogic.GetComponent<PotionCombinations>();
	    BulletColor = _potionCombinations.MixedColor;

	    switch (_potionCombinations.MixedColor)
	    {
	        case EntityColor.BLUE:
	            renderer.sharedMaterial.color = Color.blue;
	            break;
            case EntityColor.RED:
                renderer.sharedMaterial.color = Color.red;
                break;
            case EntityColor.YELLOW:
                renderer.sharedMaterial.color = Color.yellow;
                break;
            case EntityColor.PURPLE:
                renderer.sharedMaterial.color = Color.magenta;
                break;
            case EntityColor.GREEN:
                renderer.sharedMaterial.color = Color.green;
                break;
            case EntityColor.ORANGE:
                renderer.sharedMaterial.color = new Color(1f, .607f, 0f, 1f);
                break;
	    }

	    StartCoroutine(TTL());
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

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            stream.SendNext(transform.position);
        }
        else
        {
            transform.position = (Vector3) stream.ReceiveNext();
        }
    }
}
