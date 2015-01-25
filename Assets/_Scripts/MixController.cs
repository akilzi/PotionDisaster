﻿using UnityEngine;
using System.Collections;

public class MixController : MonoBehaviour
{
    public bool Red = false;
    public bool Yellow = false;
    public bool Blue = false;
    public bool Purple = false;
    public bool Green = false;
    public bool Orange = false;
    public GameObject MixtureTub;
    public GameObject PotionASelected;
    public GameObject PotionBSelected;
    public Sprite Sprite0;
    public Sprite Sprite25;
    public Sprite Sprite50;
    public Sprite Sprite75;
    public Sprite Sprite100;
    public int PotionGain = 25;
    public int PotionCost = 25;

    public int MixAmount = 0; //Can go to 100
	void Start () 
    {
        MixtureTub.renderer.sharedMaterial.color = Color.white;
        PotionASelected.renderer.sharedMaterial.color = Color.white;
        PotionBSelected.renderer.sharedMaterial.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () 
    {
        switch (MixAmount)
        {
            case 0:
                MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite0;
                break;
            case 25:
                MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite25;
                break;
            case 50:
                MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite50;
                break;
            case 75:
                MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite75;
                break;
            case 100:
                MixtureTub.GetComponent<SpriteRenderer>().sprite = Sprite100;
                break;
        }
	}

    public void MixButtonPressed()
    {
        MixAmount += PotionGain;
        if (MixAmount > 100)
        {
            MixAmount = 100;
        }

        
        Debug.Log("~~~~Mix Button Pressed~~~~");

        if (Red)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.red;
            PotionASelected.renderer.sharedMaterial.color = Color.white;
            PotionBSelected.renderer.sharedMaterial.color = Color.white;


        }
        if (Blue)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.blue;
            PotionASelected.renderer.sharedMaterial.color = Color.white;
            PotionBSelected.renderer.sharedMaterial.color = Color.white;


        }
        if (Yellow)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.yellow;
            PotionASelected.renderer.sharedMaterial.color = Color.white;
            PotionBSelected.renderer.sharedMaterial.color = Color.white;


        }
        if (Green)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.green;
            PotionASelected.renderer.sharedMaterial.color = Color.white;
            PotionBSelected.renderer.sharedMaterial.color = Color.white;


        }
        if (Purple)
        {
            MixtureTub.renderer.sharedMaterial.color = Color.magenta;
            PotionASelected.renderer.sharedMaterial.color = Color.white;
            PotionBSelected.renderer.sharedMaterial.color = Color.white;


        }
        if (Orange)
        {
            MixtureTub.renderer.sharedMaterial.color = new Color(255, 100, 0, 255);
            PotionASelected.renderer.sharedMaterial.color = Color.white;
            PotionBSelected.renderer.sharedMaterial.color = Color.white;


        }
    }

    public void Set1stPotion(Color color)
    {
        PotionASelected.renderer.sharedMaterial.color = color;
    }

    public void Set2ndPotion(Color color)
    {
        PotionBSelected.renderer.sharedMaterial.color = color;
    }

    public void EmptyTub()
    {
        MixAmount = 0;
    }

    public void ExpendPotion()
    {
        MixAmount -= PotionCost;
        if (MixAmount < 0)
        {
            MixAmount = 0;
        }
    }
}
