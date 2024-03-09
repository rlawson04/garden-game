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
    private float height = 0f;
    private float percentage = 0f;
    private float age = 0;
    private float growth = 0;
    private float yScale;
    private Vector3 position;
    

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
        if (percentage == 100)
        {
            return;
        }
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

        CalcHeight();
    }

    void CalcHeight()
    {
        height = (percentage/10);

        position = bamboo.transform.position;
        yScale = bamboo.transform.localScale.y;

        bamboo.transform.localScale = new Vector3(bamboo.transform.localScale.x, height, bamboo.transform.localScale.z);
        bamboo.transform.position = position + (bamboo.transform.forward) * (bamboo.transform.localScale.y / 2.0f + yScale / 2.0f);
    }

    void DisplayText()
    {
        infoText.text = "Current Sunshine: " + sunshine.ToString() + "\nCurrent Height: " + height.ToString()
            + "\nCurrent Growth Percentage: " + percentage.ToString() + "\nCurrent Water: " + water.ToString()
            + "\nCurrent Age: " + age.ToString() + "\nCurrent Growth: " + growth.ToString();
    }
}
