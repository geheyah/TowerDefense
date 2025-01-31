using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public Gold goldgold;
    public Transform basetower;
    public TurretScript turretscript;
    public TurretScript turretscript2;
    public TurretScript turretscript3;
    
    public Bullet bullet;
    public Button cdreduce;
    public Button bulletspeed;

    public Button smallerbase;
    
    void Start()
    {
        goldgold = GameObject.FindWithTag("Gold").GetComponent<Gold>();
        cdreduce.onClick.AddListener(CDReduce);
        bulletspeed.onClick.AddListener(BulletSpeed);
        smallerbase.onClick.AddListener(SmallBase);
    }
    
    void CDReduce()
    {
        goldgold.gold -= 5;
        turretscript.cooldown --;
        turretscript2.cooldown --;
        turretscript3.cooldown --;
    }
    
    void BulletSpeed()
    {
        goldgold.gold -= 5;
        bullet.velocity += 10f;
    }

    void SmallBase()
    {
        goldgold.gold -= 5;
        basetower.localScale = new Vector3(1, 2, 1);
        Destroy(smallerbase);
    }
    
}
