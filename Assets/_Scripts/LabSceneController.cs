using UnityEngine;
using System.Collections;

public class LabSceneController : MonoBehaviour
{

    private GameController _gameController;
	void Start ()
	{
	    _gameController = GameObject.Find("GameManager").GetComponent<GameController>();

	    if (_gameController.CharacterType == CharacterOptions.GUNNER)
	    {
            GameObject.FindGameObjectWithTag("RedButton").GetComponent<UIButton>().enabled = false;
            GameObject.FindGameObjectWithTag("BlueButton").GetComponent<UIButton>().enabled = false;
            GameObject.FindGameObjectWithTag("YellowButton").GetComponent<UIButton>().enabled = false;
            GameObject.FindGameObjectWithTag("MixButton").GetComponent<UIButton>().enabled = false;
	    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
