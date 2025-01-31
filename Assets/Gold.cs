using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gold : MonoBehaviour
{
    public int gold = 0;
    public Image upgrades;
    public TMP_Text counter;
    
    void Start()
    {
    }
    
    void Update()
    {
        counter.text = "$=" + gold.ToString();

        if (gold < 5)
        {
            upgrades.enabled = true;
            //upgrades.color = new Color(0, 0, 0, 1);
        }
        else
        {
            //upgrades.color = new Color(0, 0, 0, 0);
            upgrades.enabled = false;

        }
    }
}
