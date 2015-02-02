using UnityEngine;
using System.Collections;

public class LabSceneController : MonoBehaviour
{

    private GameController _gameController;
    private PotionCombinations _potionCombinations;

	void Start ()
	{
	    _potionCombinations = GameObject.Find("PotionLogic").GetComponent<PotionCombinations>();
	    _gameController = GameObject.Find("GameManager").GetComponent<GameController>();
	    _gameController.MixController = GameObject.Find("MixButton").GetComponent<MixController>();

	    if (_gameController.CharacterType == CharacterOptions.GUNNER)
	    {

	        GameObject player = PhotonNetwork.Instantiate("Shooter", new Vector3(2.04f, -1.09f), Quaternion.identity, 0);


	        _potionCombinations.Player = player;






	        GameObject.FindGameObjectWithTag("RedButton").GetComponent<UIButton>().enabled = false;
	        GameObject.FindGameObjectWithTag("BlueButton").GetComponent<UIButton>().enabled = false;
	        GameObject.FindGameObjectWithTag("YellowButton").GetComponent<UIButton>().enabled = false;
	        GameObject.FindGameObjectWithTag("MixButton").GetComponent<UIButton>().enabled = false;
	    }
	    else
	    {
	        _potionCombinations.Player = GameObject.Find("Shooter");
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
