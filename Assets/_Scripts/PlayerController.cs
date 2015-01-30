using UnityEngine;

public class PlayerController : MonoBehaviour
{

	private float GunForce = 50.0f; //effects shooter velocity
    public GameObject Bullet;
    private int _frameCount = 0;
    public GameObject ForcePoint;
    public bool ColorSelected = false;
    public GameObject MixButton;
    private MixController _mixController;
	private float randomNumber;
	public GameObject particleEffect;



    
	void Start ()
	{
	    _mixController = MixButton.GetComponent<MixController>();
		randomNumber = Random.Range (-360, 360);

	}

	// Update is called once per frame
	void Update ()
	{
		
		if (ColorSelected && _mixController.MixAmount > 0)
		{
			
			Vector2 bulletVector = Vector2.zero;
			Vector2 forceVector = Vector2.zero;

			if (Input.GetKey(KeyCode.UpArrow))
			{
				transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(transform.rotation.x, transform.rotation.y, 0, transform.rotation.w), GunForce/2 * Time.deltaTime);
			}


			if (Input.GetKey(KeyCode.DownArrow))
			{
				_mixController.ExpendPotion();
				forceVector += new Vector2(1, GunForce);
				bulletVector = new Vector2(100, GunForce);//effects bullet velocity
				particleEffect.particleSystem.Play();
				InstantiateBullets(KeyCode.DownArrow, bulletVector, ForcePoint.transform.position);
				//Instantiate(Bullet, ForcePoint.transform.position, ForcePoint.transform.rotation);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				if(transform.localScale.x < 0)
				{
					transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
				}
				_mixController.ExpendPotion();
				forceVector += new Vector2(-GunForce, 1);
				bulletVector = new Vector2(-GunForce, 200);//effects bullet velocity
				particleEffect.particleSystem.Play();
				InstantiateBullets(KeyCode.RightArrow, bulletVector, ForcePoint.transform.position);
				//Instantiate(Bullet, ForcePoint.transform.position, ForcePoint.transform.rotation);
			}
			else if (Input.GetKey(KeyCode.LeftArrow))
			{
				if(transform.localScale.x > 0)
				{
				transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
				}
				_mixController.ExpendPotion();
				forceVector += new Vector2(GunForce, 1);
				bulletVector = new Vector2(GunForce, 200); //effects bullet velocity
				particleEffect.particleSystem.Play();
				InstantiateBullets(KeyCode.LeftArrow, bulletVector, ForcePoint.transform.position);
				//Instantiate(Bullet, ForcePoint.transform.position, ForcePoint.transform.rotation);
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
			InstantiateBullet(position, new Vector2(0, -force.x));
            InstantiateBullet(position, new Vector2(force.y/1.25f, -force.y+50f));
            InstantiateBullet(position, new Vector2(-force.y/1.25f, -force.y+50f));
                break;
            case KeyCode.RightArrow:
			InstantiateBullet(position, new Vector2(force.y, force.y));//add formulas to adjust spread
            bForce = new Vector2(force.y, force.y); //effect bullets 2 and 3
			InstantiateBullet(position, bForce);//add formulas to adjust spread
			InstantiateBullet(position, bForce);//add formulas to adjust spread
                break;
            case KeyCode.LeftArrow:
			//InstantiateBullet(position, new Vector2(-force.y, -force.y + -2)); //add formulas to adjust spread
			bForce = new Vector2(-force.y, force.y);//effect bullets 2 and 3
			InstantiateBullet(position, bForce);//add formulas to adjust spread
			InstantiateBullet(position, bForce);//add formulas to adjust spread
                break;
        }
    }

    void InstantiateBullet(Vector3 position, Vector2 forceVector)
    {
		Bullet.transform.position = new Vector3(position.x + Random.Range (0f,.2f), position.y + Random.Range (-.2f,.2f), position.z);
        Bullet.GetComponent<BulletController>().forceVector = forceVector;
        Instantiate(Bullet);
        
		Bullet.rigidbody2D.AddForce(new Vector2(1000, 1000)); 
    }


}
