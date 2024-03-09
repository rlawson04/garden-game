using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Growth : MonoBehaviour
{
    public Text infoText;
    public int water = 0;
    public int sunshine = 0;
    public float bonus = 0f;
    public GameObject bamboo;
    float height = 0f;
    float percentage = 0f;
    float age = 0;
    float growth = 0;

    // Start is called before the first frame update
    void Start()
    {
        DisplayText();
    }

    // Update is called once per frame
    public void Update()
    {
        DisplayText();

    }

    void CalcHeight()
    {
        height = (percentage - 20)/4;
        bamboo.transform.localScale += new Vector3(0, height, 0);
    }

    public void SetBonus(float newBonus)
    {
        // Calculate the growth bonus based on the external factors nearby
    }

    public void SetWater()
    {
        if (water < 100)
        {
            if (water + 10 > 100)
            {
                water = 100;
            }
            else
            {
                water += 10;
            }
        }
    }

    public void SetSunshine()
    {
        if (sunshine < 100)
        {
            if (sunshine+10 >100)
            {
                sunshine = 100;
            }
            else
            {
                sunshine += 10;
            }
        }
    }

    public void CalcGrowth()
    {
        // Increment age
        age++;

        // Calculate growth
        growth = 1.25f + (water/20) + (sunshine/20);

        // Increase percentage until 100
        if (percentage + growth > 100)
        {
            percentage = 100;
        }
        else
        {
            percentage += growth;
        }

        // Decrease water until 0
        if (water - 20 < 0)
        {
            water = 0;
        }
        else
        { 
            water -= 20; 
        }

        // Decrease sunshine until 0
        if (sunshine - 5 < 0)
        {
            sunshine = 0;
        }
        else
        {
            sunshine -= 5;
        }
    }

    void DisplayText()
    {
        infoText.text = "Current Sunshine: " + sunshine.ToString() + "\nCurrent Height: " + height.ToString()
            + "\nCurrent Growth Percentage: " + percentage.ToString() + "\nCurrent Water: " + water.ToString()
            + "\nCurrent Age: " + age.ToString() + "\nCurrent Growth: " + growth.ToString();
    }
}
