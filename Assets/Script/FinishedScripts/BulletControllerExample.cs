using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerExample : MonoBehaviour
{
    // public static float bulletSpeed = 1000f;
    // private static int bulletDamage = 100;
    // public static int Damage { get { return bulletDamage; } set { bulletDamage = value; } }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.GetComponent<Transform>().tag == "Enemy")
    //     {
    //         if (other.GetComponentInParent<EnemyController>().Health > 0)
    //             other.GetComponentInParent<EnemyController>().Health -= Damage;

    //         if (other.GetComponentInParent<EnemyController>().Health <= 0 &&
    //             other.GetComponentInParent<EnemyController>().isDead == false)
    //             PlayerController.Score += 10;

    //     }
    //     ObjectPools.Instance.ReturnToPool(this);
    // }
}
