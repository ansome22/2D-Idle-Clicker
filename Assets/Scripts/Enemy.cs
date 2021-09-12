using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public int curHp;
    public int maxHp;
    public int goldToGive;
    public Image healthBarFill;
    public Animation anim;
    public void Damage()
    {
        anim.Stop();
        anim.Play();
        //Subtract 1 from curHP
        curHp--;
        //Update health bar & convert the value to a float
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;
        if (curHp <= 0)
        {
            Defeated();
        }
    }
    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}