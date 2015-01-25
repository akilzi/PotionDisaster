using UnityEngine;
using System.Collections;

public class PotionCombinations : MonoBehaviour
{

    public bool Red = false;
    public bool Yellow = false;
    public bool Blue = false;
    public bool Purple = false;
    public bool Green = false;
    public bool Orange = false;
    private int numberOfPotionsSelected = 1;
    public string potionA;
    public string potionB;
    public string mixtures;
    public GameObject mixtureTub;
    public GameObject Potion_A_Selected;
    public GameObject Potion_B_Selected;
    public GameObject mixButton;
    public Color SelectedColor;
    public GameObject Player;
    private PlayerController _playerController;

    // Use this for initialization
    private void Start()
    {
        _playerController = Player.GetComponent<PlayerController>();

        Debug.Log(numberOfPotionsSelected);
        mixtureTub.renderer.sharedMaterial.color = Color.white;
        mixButton.renderer.sharedMaterial.color = Color.white;
        Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
        Potion_B_Selected.renderer.sharedMaterial.color = Color.white;
        SelectedColor = Color.white;
    }

    private void Update()
    {
        if (potionA == "Red" && potionB == "Red")
        {
            mixtures = "Super Red";
            mixButton.renderer.sharedMaterial.color = Color.red;
            SelectedColor = Color.red;
            Red = true;
            Blue = false;
            Yellow = false;
            Purple = false;
            Orange = false;
            Green = false;
        }
        else if (potionA == "Blue" && potionB == "Blue")
        {
            mixtures = "Super Blue";
            mixButton.renderer.sharedMaterial.color = Color.blue;
            SelectedColor = Color.blue;
            Red = false;
            Blue = true;
            Yellow = false;
            Purple = false;
            Orange = false;
            Green = false;
        }
        else if (potionA == "Yellow" && potionB == "Yellow")
        {
            mixtures = "Super Yellow";
            mixButton.renderer.sharedMaterial.color = Color.yellow;
            SelectedColor = Color.yellow;
            Red = false;
            Blue = false;
            Yellow = true;
            Purple = false;
            Orange = false;
            Green = false;
        }
        else if (potionA == "Red" && potionB == "Blue")
        {
            mixtures = "Purple";
            mixButton.renderer.sharedMaterial.color = Color.magenta;
            SelectedColor = Color.magenta;
            Red = false;
            Blue = false;
            Yellow = false;
            Purple = true;
            Orange = false;
            Green = false;
        }
        else if (potionA == "Blue" && potionB == "Red")
        {
            mixtures = "Purple";
            mixButton.renderer.sharedMaterial.color = Color.magenta;
            SelectedColor = Color.magenta;
            Red = false;
            Blue = false;
            Yellow = false;
            Purple = true;
            Orange = false;
            Green = false;
        }
        else if (potionA == "Red" && potionB == "Yellow")
        {
            mixtures = "Orange";
            mixButton.renderer.sharedMaterial.color = new Color(255, 100, 0, 255);
            SelectedColor = new Color(255, 100, 0, 255);
            Red = false;
            Blue = false;
            Yellow = false;
            Purple = false;
            Orange = true;
            Green = false;
        }
        else if (potionA == "Yellow" && potionB == "Red")
        {
            mixtures = "Orange";
            mixButton.renderer.sharedMaterial.color = new Color(255, 100, 0, 255);
            SelectedColor = new Color(255, 100, 0, 255);
            Red = false;
            Blue = false;
            Yellow = false;
            Purple = false;
            Orange = true;
            Green = false;
        }
        else if (potionA == "Blue" && potionB == "Yellow")
        {
            mixtures = "Green";
            mixButton.renderer.sharedMaterial.color = Color.green;
            SelectedColor = Color.green;
            Red = false;
            Blue = false;
            Yellow = false;
            Purple = false;
            Orange = false;
            Green = true;
        }
        else if (potionA == "Yellow" && potionB == "Blue")
        {
            mixtures = "Green";
            mixButton.renderer.sharedMaterial.color = Color.green;
            SelectedColor = Color.green;
            Red = false;
            Blue = false;
            Yellow = false;
            Purple = false;
            Orange = false;
            Green = true;
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
            Potion_B_Selected.renderer.sharedMaterial.color = Color.red;
            checkMixtures();
            Debug.Log("mixture complete" + ", " + "potions are:" + " " + "potion A =" + " " + potionA + ", " +
                      "potion B =" + " " + potionB + " -- " + "mixture is:" + " " + mixtures);
            numberOfPotionsSelected = 1;
        }
        else
        {
            numberOfPotionsSelected ++;
            //Red = true;
            potionA = "Red";
            Potion_A_Selected.renderer.sharedMaterial.color = Color.red;
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
            Potion_B_Selected.renderer.sharedMaterial.color = Color.blue;
            checkMixtures();
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
            Potion_A_Selected.renderer.sharedMaterial.color = Color.blue;

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
            Potion_B_Selected.renderer.sharedMaterial.color = Color.yellow;
            checkMixtures();
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
            Potion_A_Selected.renderer.sharedMaterial.color = Color.yellow;

        }
    }

    //CHECK MIXTURES

    private void checkMixtures()
    {
        //Debug.Log("Mixture Tested");
        if (potionA == "Red" && potionB == "Red")
        {
            mixtures = "Super Red";
            mixtureTub.renderer.sharedMaterial.color = Color.red;
            SelectedColor = Color.red;
        }
        if (potionA == "Blue" && potionB == "Blue")
        {
            mixtures = "Super Blue";
            mixtureTub.renderer.sharedMaterial.color = Color.blue;
            SelectedColor = Color.blue;
        }
        if (potionA == "Yellow" && potionB == "Yellow")
        {
            mixtures = "Super Yellow";
            mixtureTub.renderer.sharedMaterial.color = Color.yellow;
            SelectedColor = Color.yellow;
        }
        if (potionA == "Red" && potionB == "Blue")
        {
            mixtures = "Purple";
            mixtureTub.renderer.sharedMaterial.color = Color.magenta;
            SelectedColor = Color.magenta;
        }
        if (potionA == "Blue" && potionB == "Red")
        {
            mixtures = "Purple";
            mixtureTub.renderer.sharedMaterial.color = Color.magenta;
            SelectedColor = Color.magenta;
        }
        if (potionA == "Red" && potionB == "Yellow")
        {
            mixtures = "Orange";
            mixtureTub.renderer.sharedMaterial.color = new Color(255, 100, 0, 255);
            SelectedColor = new Color(255, 100, 0, 255);
        }
        if (potionA == "Yellow" && potionB == "Red")
        {
            mixtures = "Orange";
            mixtureTub.renderer.sharedMaterial.color = new Color(255, 100, 0, 255);
            SelectedColor = new Color(255, 100, 0, 255);
        }
        if (potionA == "Blue" && potionB == "Yellow")
        {
            mixtures = "Green";
            mixtureTub.renderer.sharedMaterial.color = Color.green;
            SelectedColor = Color.green;
        }
        if (potionA == "Yellow" && potionB == "Blue")
        {
            mixtures = "Green";
            mixtureTub.renderer.sharedMaterial.color = Color.green;
            SelectedColor = Color.green;
        }

    }

    public void MixButtonPressed()

    {

        Debug.Log("~~~~Mix Button Pressed~~~~");

        if (Red)
        {
            mixtureTub.renderer.sharedMaterial.color = Color.red;
            Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
            Potion_B_Selected.renderer.sharedMaterial.color = Color.white;


        }
        if (Blue)
        {
            mixtureTub.renderer.sharedMaterial.color = Color.blue;
            Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
            Potion_B_Selected.renderer.sharedMaterial.color = Color.white;


        }
        if (Yellow)
        {
            mixtureTub.renderer.sharedMaterial.color = Color.yellow;
            Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
            Potion_B_Selected.renderer.sharedMaterial.color = Color.white;


        }
        if (Green)
        {
            mixtureTub.renderer.sharedMaterial.color = Color.green;
            Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
            Potion_B_Selected.renderer.sharedMaterial.color = Color.white;


        }
        if (Purple)
        {
            mixtureTub.renderer.sharedMaterial.color = Color.magenta;
            Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
            Potion_B_Selected.renderer.sharedMaterial.color = Color.white;


        }
        if (Orange)
        {
            mixtureTub.renderer.sharedMaterial.color = new Color(255, 100, 0, 255);
            Potion_A_Selected.renderer.sharedMaterial.color = Color.white;
            Potion_B_Selected.renderer.sharedMaterial.color = Color.white;


        }
    }
}