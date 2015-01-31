using UnityEngine;
using System.Collections;

public class PotionCombinations : MonoBehaviour
{
    public string potionA;
    public string potionB;
    public string mixtures;
    public GameObject MixButton;
    public GameObject MixButtonButton;
    public GameObject Player;
    public EntityColor MixedColor;

    private int numberOfPotionsSelected = 1;
    private PlayerController _playerController;
    private MixController _mixController;

    

    // Use this for initialization
    private void Start()
    {
        _playerController = Player.GetComponent<PlayerController>();
        _mixController = MixButtonButton.GetComponent<MixController>();

        Debug.Log(numberOfPotionsSelected);
        
        MixButton.renderer.sharedMaterial.color = Color.white;
        
        MixedColor = EntityColor.WHITE;
    }

    private void Update()
    {
        if (potionA == "Red" && potionB == "Red")
        {
            mixtures = "Super Red";
            MixButton.renderer.sharedMaterial.color = Color.red;
            MixedColor = EntityColor.RED;
        }
        else if (potionA == "Blue" && potionB == "Blue")
        {
            mixtures = "Super Blue";
            MixButton.renderer.sharedMaterial.color = Color.blue;
            MixedColor = EntityColor.BLUE;
        }
        else if (potionA == "Yellow" && potionB == "Yellow")
        {
            mixtures = "Super Yellow";
            MixButton.renderer.sharedMaterial.color = Color.yellow;
            MixedColor = EntityColor.YELLOW;
        }
        else if (potionA == "Red" && potionB == "Blue")
        {
            mixtures = "Purple";
            MixButton.renderer.sharedMaterial.color = Color.magenta;
            MixedColor = EntityColor.PURPLE;
        }
        else if (potionA == "Blue" && potionB == "Red")
        {
            mixtures = "Purple";
            MixButton.renderer.sharedMaterial.color = Color.magenta;
            MixedColor = EntityColor.PURPLE;
        }
        else if (potionA == "Red" && potionB == "Yellow")
        {
            mixtures = "Orange";
			MixButton.renderer.material.color = new Color(1f, .607f, 0f, 1f);
		    MixedColor = EntityColor.ORANGE;
        }
        else if (potionA == "Yellow" && potionB == "Red")
        {
            mixtures = "Orange";
			MixButton.renderer.sharedMaterial.color = new Color(1f, .607f, 0f, 1f);
		    MixedColor = EntityColor.ORANGE;
        }
        else if (potionA == "Blue" && potionB == "Yellow")
        {
            mixtures = "Green";
            MixButton.renderer.sharedMaterial.color = Color.green;
            MixedColor = EntityColor.GREEN;
        }
        else if (potionA == "Yellow" && potionB == "Blue")
        {
            mixtures = "Green";
            MixButton.renderer.sharedMaterial.color = Color.green;
            MixedColor = EntityColor.GREEN;
        }
    }


    //RED

    public void redActive()
    {
        Debug.Log(numberOfPotionsSelected);
        if (numberOfPotionsSelected == 2)
        {
            _playerController.ColorSelected = true;
            potionB = "Red";
            _mixController.Set2ndPotion(Color.red);
            Debug.Log("mixture complete" + ", " + "potions are:" + " " + "potion A =" + " " + potionA + ", " +
                      "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
            numberOfPotionsSelected = 1;
        }
        else
        {
            numberOfPotionsSelected ++;
            //Red = true;
            potionA = "Red";
            _mixController.Set1stPotion(Color.red);
            //checkMixtures ();
        }
    }

    //BLUE

    public void blueActive()
    {
        Debug.Log(numberOfPotionsSelected);
        if (numberOfPotionsSelected == 2)
        {
            _playerController.ColorSelected = true;
            potionB = "Blue";
            _mixController.Set2ndPotion(Color.blue);
            Debug.Log("mixture complete" + ", " + "potions are:" + " " + "potion A =" + " " + potionA + ", " +
                      "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
            numberOfPotionsSelected = 1;
            //potionA = " ";
            //potionB = " ";
        }
        else
        {
            numberOfPotionsSelected ++;
            //Blue = true;
            potionA = "Blue";
            _mixController.Set1stPotion(Color.blue);

        }
    }

    //YELLOW

    public void yellowActive()
    {

        Debug.Log(numberOfPotionsSelected);
        if (numberOfPotionsSelected == 2)
        {
            _playerController.ColorSelected = true;
            potionB = "Yellow";
            _mixController.Set2ndPotion(Color.yellow);
            Debug.Log("mixture complete" + ", " + "potions are:" + " " + "potion A =" + " " + potionA + ", " +
                      "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
            numberOfPotionsSelected = 1;
            //potionA = " ";
            //potionB = " ";
        }
        else
        {
            numberOfPotionsSelected ++;
            //Yellow = true;
            potionA = "Yellow";
            _mixController.Set1stPotion(Color.yellow);

        }
    }

    
}