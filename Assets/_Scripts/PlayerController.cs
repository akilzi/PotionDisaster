using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float GunForce = 250.0f;
    public GameObject Bullet;
    private int _frameCount = 0;
    public GameObject ForcePoint;
    public bool ColorSelected = false;
    public GameObject MixButton;
    private MixController _mixController;
    
	void Start ()
	{
	    _mixController = MixButton.GetComponent<MixController>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    if (Input.GetKey(KeyCode.UpArrow))
	    {
	          transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(transform.rotation.x, transform.rotation.y, 0, transform.rotation.w), GunForce/2 * Time.deltaTime);
	    }

	    if (ColorSelected && _mixController.MixAmount > 0)
	    {
	        Vector2 bulletVector = Vector2.zero;
	        Vector2 forceVector = Vector2.zero;
	        if (Input.GetKey(KeyCode.DownArrow))
	        {
                _mixController.ExpendPotion();
	            forceVector += new Vector2(0, GunForce);
	            bulletVector = new Vector2(0, GunForce);
	            InstantiateBullets(KeyCode.DownArrow, bulletVector, ForcePoint.transform.position);
	        }
	        if (Input.GetKey(KeyCode.RightArrow))
	        {
                _mixController.ExpendPotion();
	            forceVector += new Vector2(-GunForce, 0);
	            bulletVector = new Vector2(-GunForce, 0);
	            InstantiateBullets(KeyCode.RightArrow, bulletVector, ForcePoint.transform.position);
	        }
	        else if (Input.GetKey(KeyCode.LeftArrow))
	        {
                _mixController.ExpendPotion();
	            forceVector += new Vector2(GunForce, 0);
	            bulletVector = new Vector2(GunForce, 0);
	            InstantiateBullets(KeyCode.LeftArrow, bulletVector, ForcePoint.transform.position);
	        }

	        transform.rigidbody2D.AddForce(forceVector);
	    }
	}

    void InstantiateBullets(KeyCode keyPress, Vector2 force, Vector3 position)
    {
        var bForce = Vector2.zero;
        switch (keyPress)
        {       
            case KeyCode.DownArrow:
                InstantiateBullet(position, force);
                //InstantiateBullet(position, new Vector2(force.y/10f, -force.y+50f));
                //InstantiateBullet(position, new Vector2(-force.y/10f, -force.y+50f));
                break;
            case KeyCode.RightArrow:
                InstantiateBullet(position, force);
                bForce = new Vector2(force.x - 50f, force.x/10f);
                //InstantiateBullet(position, bForce);
                //InstantiateBullet(position, new Vector2(bForce.x, -bForce.y));
                break;
            case KeyCode.LeftArrow:
                InstantiateBullet(position, force);
                bForce = new Vector2(-force.x + 50f, force.x / 10f);
                //InstantiateBullet(position, bForce);
                //InstantiateBullet(position, new Vector2(bForce.x, -bForce.y));
                break;
        }
    }

    void InstantiateBullet(Vector3 position, Vector2 forceVector)
    {
        Bullet.transform.position = new Vector3(position.x, position.y, position.z);
        Bullet.GetComponent<BulletController>().forceVector = forceVector;
        GameObject.Instantiate(Bullet);
        
        Bullet.rigidbody2D.AddForce(forceVector);
    }
}
