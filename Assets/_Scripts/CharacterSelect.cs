using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {

	public bool isGunner = false;
	public bool isChemist = false;

	void Start()
	{
		DontDestroyOnLoad(this);
	}

	public void GunnerSelected()
	{
		isGunner = true;
	}

	public void ChemistSelected()
	{
		isChemist = true;
	}
}
