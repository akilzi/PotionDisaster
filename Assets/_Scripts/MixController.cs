using UnityEngine;

public class MixController : Photon.MonoBehaviour
{
    public GameObject MixtureTub;
    public GameObject PotionASelected;
    public GameObject PotionBSelected;
    public Sprite Sprite0;
    public Sprite Sprite25;
    public Sprite Sprite50;
    public Sprite Sprite75;
    public Sprite Sprite100;
    public EntityColor MixedColor;
    public int PotionGain = 25;
    public int PotionCost = 0;

    public int MixAmount = 0; //Can go to 100
	void Start () 
    {
        MixtureTub.renderer.sharedMaterial.color = Color.white;
        PotionASelected.renderer.sharedMaterial.color = Color.white;
        PotionBSelected.renderer.sharedMaterial.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (MixAmount == 0)
	    {
            MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite0;
                
	    } else if (MixAmount <= 25)
	    {
            MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite25;
                
	    } else if (MixAmount <= 50)
	    {
            MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite50;
                
	    } else if (MixAmount <= 75)
	    {
            MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite75;
                
	    } else if (MixAmount <= 100)
	    {
            MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite100;
                
	    }
	}

    public void MixButtonPressed()
    {
        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            photonView.RPC("RPCMixButtonPressed", PhotonTargets.All);
        }
    }

    [RPC]
    void RPCMixButtonPressed()
    {
        MixAmount += PotionGain;
        if (MixAmount > 100)
        {
            MixAmount = 100;
        }


        Debug.Log("~~~~Mix Button Pressed~~~~");

        if (MixedColor == EntityColor.RED)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.red;
        }
        if (MixedColor == EntityColor.BLUE)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.blue;
        }
        if (MixedColor == EntityColor.YELLOW)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.yellow;
        }
        if (MixedColor == EntityColor.ORANGE)
        {
            MixtureTub.renderer.sharedMaterial.color = new Color(1f, .607f, 0f, 1f); ;
        }
        if (MixedColor == EntityColor.GREEN)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.green;
        }
        if (MixedColor == EntityColor.PURPLE)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.yellow;
        }
    }

    public void Set1stPotion(Color color)
    {
        PotionASelected.renderer.sharedMaterial.color = color;
    }

    public void Set2ndPotion(Color color)
    {
        PotionBSelected.renderer.sharedMaterial.color = color;
    }

    public void EmptyTub()
    {
        MixAmount = 0;
    }

    public void ExpendPotion()
    {
        MixAmount -= PotionCost;
        if (MixAmount < 0)
        {
            MixAmount = 0;
        }
    }

    
}
