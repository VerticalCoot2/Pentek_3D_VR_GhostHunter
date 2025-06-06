using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public static float bulletSpeed = 1000;
    private static int bulletDamage = 100;

    public static int Damage { get{ return bulletDamage; } set { bulletDamage = value; } } 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
