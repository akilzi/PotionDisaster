using UnityEngine;
using System.Collections;

public class CharacterSelect : Photon.MonoBehaviour {

	public bool isGunner = false;
	public bool isChemist = false;
    private bool isReady = false;
    private GameController _gameManager;

	void Start()
	{
		DontDestroyOnLoad(this);

	    _gameManager = GameObject.Find("GameManager").GetComponent<GameController>();
	}

    void Update()
    {
        if (isGunner && isChemist && _gameManager.GameState == GameState.INITIALIZING)
        {
            _gameManager.NextState();
        }
        else
        {
            Debug.Log("Waiting For Other Player To Join");
        }
    }

	public void GunnerSelected()
	{
	    if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
	    {
	        this.photonView.RPC("RPCSelectGunner", PhotonTargets.All);
	    }
	}

	public void ChemistSelected()
	{
        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            this.photonView.RPC("RPCSelectChemist", PhotonTargets.All);
        }
	}

    [RPC]
    void RPCSelectGunner()
    {
        isGunner = true;
    }

    [RPC]
    void RPCSelectChemist()
    {
        isChemist = true;
    }
}
