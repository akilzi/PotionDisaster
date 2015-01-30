using UnityEngine;
using System.Collections;

public class PotionCombinations : MonoBehaviour
{

    
    private int numberOfPotionsSelected = 1;
    public string potionA;
    public string potionB;
    public string mixtures;
    
    
    public GameObject MixButton;
    public GameObject MixButtonButton;
    public Color SelectedColor;
    public GameObject Player;
    private PlayerController _playerController;
    private MixController _mixController;
    

    // Use this for initialization
    private void Start()
    {
        _playerController = Player.GetComponent<PlayerController>();
        _mixController = MixButtonButton.GetComponent<MixController>();

        Debug.Log(numberOfPotionsSelected);
        
        MixButton.renderer.sharedMaterial.color = Color.white;
        
        SelectedColor = Color.white;
    }

    private void Update()
    {
        _mixController.Red = false;
        _mixController.Yellow = false;
        _mixController.Blue = false;
        _mixController.Purple = false;
        _mixController.Green = false;
        _mixController.Orange = false;
        if (potionA == "Red" && potionB == "Red")
        {
            mixtures = "Super Red";
            MixButton.renderer.sharedMaterial.color = Color.red;
            SelectedColor = Color.red;
            _mixController.Red = true;
        }
        else if (potionA == "Blue" && potionB == "Blue")
        {
            mixtures = "Super Blue";
            MixButton.renderer.sharedMaterial.color = Color.blue;
            SelectedColor = Color.blue;
            _mixController.Blue = true;
        }
        else if (potionA == "Yellow" && potionB == "Yellow")
        {
            mixtures = "Super Yellow";
            MixButton.renderer.sharedMaterial.color = Color.yellow;
            SelectedColor = Color.yellow;
            _mixController.Yellow = true;
        }
        else if (potionA == "Red" && potionB == "Blue")
        {
            mixtures = "Purple";
            MixButton.renderer.sharedMaterial.color = Color.magenta;
            SelectedColor = Color.magenta;
            _mixController.Purple = true;
        }
        else if (potionA == "Blue" && potionB == "Red")
        {
            mixtures = "Purple";
            MixButton.renderer.sharedMaterial.color = Color.magenta;
            SelectedColor = Color.magenta;
            _mixController.Purple = true;
        }
        else if (potionA == "Red" && potionB == "Yellow")
        {
            mixtures = "Orange";
			MixButton.renderer.material.color = new Color(1f, .607f, 0f, 1f);
			SelectedColor = new Color(1f, .607f, 0f, 1f);
            _mixController.Orange = true;
        }
        else if (potionA == "Yellow" && potionB == "Red")
        {
            mixtures = "Orange";
			MixButton.renderer.sharedMaterial.color = new Color(1f, .607f, 0f, 1f);
			SelectedColor = new Color(1f, .607f, 0f, 1f);
            _mixController.Orange = true;
        }
        else if (potionA == "Blue" && potionB == "Yellow")
        {
            mixtures = "Green";
            MixButton.renderer.sharedMaterial.color = Color.green;
            SelectedColor = Color.green;
            _mixController.Green = true;
        }
        else if (potionA == "Yellow" && potionB == "Blue")
        {
            mixtures = "Green";
            MixButton.renderer.sharedMaterial.color = Color.green;
            SelectedColor = Color.green;
            _mixController.Green = true;
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