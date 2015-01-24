using UnityEngine;
using System.Collections;

public class PotionCombinations : MonoBehaviour {

	bool Red = false;
	bool Yellow = false;
	bool Blue = false;
	int numberOfPotionsSelected = 1;
	string potionA;
	string potionB;
	string mixtures;
	public GameObject mixtureTub;

	// Use this for initialization
	void Start () {
		Debug.Log (numberOfPotionsSelected);
		mixtureTub.renderer.sharedMaterial.color = Color.white;
	}
	
	// Update is called once per frame
	void Update() {

	}


//RED

	public void redActive ()
	{
		Debug.Log (numberOfPotionsSelected);
		if (numberOfPotionsSelected == 2)
		{
			potionB = "Red";
			checkMixtures ();
			Debug.Log ("mixture complete" + ", " + "potions are:" + " " +  "potion A =" + " " + potionA + ", " + "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
			numberOfPotionsSelected = 1;
			potionA = " ";
			potionB = " ";
		}
		else
		{
			numberOfPotionsSelected ++;
			Red = true;
			potionA = "Red";
			checkMixtures ();
		}
	}

//BLUE

	public void blueActive ()
	{
		Debug.Log (numberOfPotionsSelected);
		if (numberOfPotionsSelected == 2)
		{
			potionB = "Blue";
			checkMixtures ();
			Debug.Log ("mixture complete" + ", " + "potions are:" + " " +  "potion A =" + " " + potionA + ", " + "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
			numberOfPotionsSelected = 1;
			potionA = " ";
			potionB = " ";
		}
		else
		{
			numberOfPotionsSelected ++;
			Blue = true;
			potionA = "Blue";
			checkMixtures ();
		}
	}

//YELLOW

	public void yellowActive ()
	{
		Debug.Log (numberOfPotionsSelected);
		if (numberOfPotionsSelected == 2) 
		{
			potionB = "Yellow";
			checkMixtures ();
			Debug.Log ("mixture complete" + ", " + "potions are:" + " " +  "potion A =" + " " + potionA + ", " + "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
			numberOfPotionsSelected = 1;
			potionA = " ";
			potionB = " ";
		} 
		else 
		{
			numberOfPotionsSelected ++;
			Yellow = true;
			potionA = "Yellow";
			checkMixtures ();
		}
	}

//CHECK MIXTURES

	void checkMixtures ()
		{
		//Debug.Log("Mixture Tested");
				if (potionA == "Red" && potionB == "Red") {
						mixtures = "Super Red";
						mixtureTub.renderer.sharedMaterial.color = Color.red;
				}
				if (potionA == "Blue" && potionB == "Blue") {
						mixtures = "Super Blue";
						mixtureTub.renderer.sharedMaterial.color = Color.blue;
				}
				if (potionA == "Yellow" && potionB == "Yellow") {
						mixtures = "Super Yellow";
						mixtureTub.renderer.sharedMaterial.color = Color.yellow;
				}
				if (potionA == "Red" && potionB == "Blue") {
						mixtures = "Purple";
						mixtureTub.renderer.sharedMaterial.color = Color.magenta;
				}
				if (potionA == "Blue" && potionB == "Red") {
						mixtures = "Purple";
						mixtureTub.renderer.sharedMaterial.color = Color.magenta;
				}
				if (potionA == "Red" && potionB == "Yellow") {
						mixtures = "Orange";
						mixtureTub.renderer.sharedMaterial.color = Color.black;
				}
				if (potionA == "Yellow" && potionB == "Red") {
						mixtures = "Orange";
						mixtureTub.renderer.sharedMaterial.color = Color.black;
				}
				if (potionA == "Blue" && potionB == "Yellow") {
						mixtures = "Green";
						mixtureTub.renderer.sharedMaterial.color = Color.green;
				}
				if (potionA == "Yellow" && potionB == "Blue") {
						mixtures = "Green";
						mixtureTub.renderer.sharedMaterial.color = Color.green;
				}

		}
}
