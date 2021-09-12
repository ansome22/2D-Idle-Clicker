using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;
    public static GameManager instance;
    //Array that holds all of our different backgrounds.
    public Sprite[] backgrounds;
    //Current index to go through each element of the sprite array individually
    private int curBackground;
    //How many enemies do we need to defeat until the background is changed?
    private int enemiesUntilBackgroundChange = 5;
    //Referencing the UI image component
    public Image backgroundImage;
    void Awake()
    {
        instance = this;
    }
    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;
        if (enemiesUntilBackgroundChange == 0)
        {
            curBackground++;
            enemiesUntilBackgroundChange = 5;
            //If there is no more background left in the array, reset curBackground.
            if (curBackground == backgrounds.Length)
            {
                curBackground = 0;
            }
            //Update backgroundImage to curBackground.
            backgroundImage.sprite = backgrounds[curBackground];
        }
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = "Gold: " + gold.ToString();
    }
    public void TakeGold(int amount)
    {
        gold -= amount;
        goldText.text = "Gold: " + gold.ToString();
    }
}
