using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClickerLastTime = new List<float>();
    public TextMeshProUGUI quantityText;
    public int autoClickerPrice;
    // Start is called before the first frame update
    void Update()
    {
        for (int i = 0; i < autoClickerLastTime.Count; i++)
        {
            if (Time.time - autoClickerLastTime[i] >= 1.0f)
            {
                autoClickerLastTime[i] = Time.time;
                EnemyManager.instance.curEnemy.Damage();
            }
        }
    }
    public void OnBuyAutoClicker()
    {
        // if we have enough gold to buy the autoclicker,
        if (GameManager.instance.gold >= autoClickerPrice)
        {
            GameManager.instance.TakeGold(autoClickerPrice);
            autoClickerLastTime.Add(Time.time);
            //set the text to display the length of the list.
            quantityText.text = "x " + autoClickerLastTime.Count.ToString();
        }
    }


}
