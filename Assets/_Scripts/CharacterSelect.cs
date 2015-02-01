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

        _gameManager.CharacterType = CharacterOptions.GUNNER;
	    if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
	    {
	        photonView.RPC("RPCSelectGunner", PhotonTargets.All);
	    }
	}

	public void ChemistSelected()
	{
        _gameManager.CharacterType = CharacterOptions.CHEMIST;
        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            photonView.RPC("RPCSelectChemist", PhotonTargets.All);
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
