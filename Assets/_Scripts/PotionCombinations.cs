using UnityEngine;
using System.Collections;

public class PotionCombinations : Photon.MonoBehaviour
{
    public string PotionA;
    public string PotionB;
    public string Mixtures;
    public GameObject MixButton;
    public GameObject MixButtonButton;
    public GameObject Player;
    public EntityColor MixedColor;

    private int _numberOfPotionsSelected = 1;
    private MixController _mixController;
    private GameController _gameController;

    private void Start()
    {
        
        _mixController = MixButtonButton.GetComponent<MixController>();
        _gameController = GameObject.Find("GameManager").GetComponent<GameController>();

        Debug.Log(_numberOfPotionsSelected);
        
        MixButton.renderer.sharedMaterial.color = Color.white;
        
        MixedColor = EntityColor.WHITE;
    }

    private void Update()
    {
        if (PotionA == "Red" && PotionB == "Red")
        {
            Mixtures = "Super Red";
            MixButton.renderer.sharedMaterial.color = Color.red;
            MixedColor = EntityColor.RED;
        }
        else if (PotionA == "Blue" && PotionB == "Blue")
        {
            Mixtures = "Super Blue";
            MixButton.renderer.sharedMaterial.color = Color.blue;
            MixedColor = EntityColor.BLUE;
        }
        else if (PotionA == "Yellow" && PotionB == "Yellow")
        {
            Mixtures = "Super Yellow";
            MixButton.renderer.sharedMaterial.color = Color.yellow;
            MixedColor = EntityColor.YELLOW;
        }
        else if (PotionA == "Red" && PotionB == "Blue")
        {
            Mixtures = "Purple";
            MixButton.renderer.sharedMaterial.color = Color.magenta;
            MixedColor = EntityColor.PURPLE;
        }
        else if (PotionA == "Blue" && PotionB == "Red")
        {
            Mixtures = "Purple";
            MixButton.renderer.sharedMaterial.color = Color.magenta;
            MixedColor = EntityColor.PURPLE;
        }
        else if (PotionA == "Red" && PotionB == "Yellow")
        {
            Mixtures = "Orange";
			MixButton.renderer.material.color = new Color(1f, .607f, 0f, 1f);
		    MixedColor = EntityColor.ORANGE;
        }
        else if (PotionA == "Yellow" && PotionB == "Red")
        {
            Mixtures = "Orange";
			MixButton.renderer.sharedMaterial.color = new Color(1f, .607f, 0f, 1f);
		    MixedColor = EntityColor.ORANGE;
        }
        else if (PotionA == "Blue" && PotionB == "Yellow")
        {
            Mixtures = "Green";
            MixButton.renderer.sharedMaterial.color = Color.green;
            MixedColor = EntityColor.GREEN;
        }
        else if (PotionA == "Yellow" && PotionB == "Blue")
        {
            Mixtures = "Green";
            MixButton.renderer.sharedMaterial.color = Color.green;
            MixedColor = EntityColor.GREEN;
        }

        if (MixedColor != EntityColor.WHITE)
        {
            _mixController.MixedColor = MixedColor;
            _gameController.ColorSelected = true;
        }
        
    }

    [RPC]
    void RPCAddRedPotion()
    {
        if (_numberOfPotionsSelected == 2)
        {
            _gameController.ColorSelected = true;
            PotionB = "Red";
            _mixController.Set2ndPotion(Color.red);
            _numberOfPotionsSelected = 0;
        }
        else
        {
            _numberOfPotionsSelected++;
            PotionA = "Red";
            _mixController.Set1stPotion(Color.red);
        }
    }

    [RPC]
    void RPCAddBluePotion()
    {
        if (_numberOfPotionsSelected == 2)
        {
            _gameController.ColorSelected = true;
            PotionB = "Blue";
            _mixController.Set2ndPotion(Color.blue);
            _numberOfPotionsSelected = 0;
        }
        else
        {
            _numberOfPotionsSelected++;
            PotionA = "Blue";
            _mixController.Set1stPotion(Color.blue);
        }
    }

    [RPC]
    void RPCAddYellowPotion()
    {
        if (_numberOfPotionsSelected == 2)
        {
            _gameController.ColorSelected = true;
            PotionB = "Yellow";
            _mixController.Set2ndPotion(Color.yellow);
            _numberOfPotionsSelected = 0;
        }
        else
        {
            _numberOfPotionsSelected++;
            PotionA = "Yellow";
            _mixController.Set1stPotion(Color.yellow);
        }
    }
    //RED
    public void AddRedPotion()
    {
        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            photonView.RPC("RPCAddRedPotion", PhotonTargets.All);
        }
    }

    //BLUE

    public void AddBluePotion()
    {
        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            photonView.RPC("RPCAddBluePotion", PhotonTargets.All);
        }
    }

    //YELLOW

    public void AddYellowPotion()
    {

        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            photonView.RPC("RPCAddYellowPotion", PhotonTargets.All);
        }
    }

    //void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    //{
    //    if (stream.isWriting)
    //    {
    //        stream.SendNext(potionA);
    //        stream.SendNext(potionB);
    //        stream.SendNext((int)MixedColor);
    //    }
    //    else
    //    {
    //        potionA = (string)stream.ReceiveNext();
    //        potionB = (string)stream.ReceiveNext();
    //        MixedColor = (EntityColor)stream.ReceiveNext();
    //    }
    //}
}