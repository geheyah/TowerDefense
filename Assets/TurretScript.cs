using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class TurretScript : MonoBehaviour
{
    public Transform turret;
    public Transform target;
    public GameObject bullet;
    
    //cooldown
    public float cooldown = 1f;
    public float last;
    
    //gold
    

    

    private void Shoot()
    {
        if (Time.time - last < cooldown)
        {
            return;
        }

        last = Time.time;
            
        GameObject bulletObject = Instantiate(bullet,turret.position, turret.rotation);
    }
    void Update()
    {
        
        FindTarget();

        if (target != null)
        {
            Look(turret.transform);
            Shoot();
        }
    }
    float Dot(Vector3 start, Vector3 end)
    {
        return start.x * end.x + start.y * end.y + start.z * end.z;
    }

    Vector3 Dot2(Vector3 start, Vector3 end)
    {
        return new Vector3(start.x * end.x, start.y * end.y, start.z * end.z);
    }

    void FindTarget()
    {
        if (target != null) return;

        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length > 0)
            target = enemies[0].transform;
    }

    void Look(Transform objectToRotate)
    {
        if (target == null) return;
        var dotproduct = Dot2(objectToRotate.position, target.position);
        var angle = Mathf.Atan2(dotproduct.y, dotproduct.x) * Mathf.Rad2Deg;
        
        objectToRotate.rotation = Quaternion.Lerp(objectToRotate.rotation, Quaternion.Euler(0, 0,angle), Time.deltaTime * 5f);
    }
}
