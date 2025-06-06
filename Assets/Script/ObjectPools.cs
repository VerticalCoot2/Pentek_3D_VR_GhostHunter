using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPools : MonoBehaviour
{
    public BulletScript bulletPrefab;

    private Queue<BulletScript> bullets = new Queue<BulletScript>();

    public static ObjectPools Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    public BulletScript GetBullet()
    {
        if(bullets.Count == 0)
        {
            BulletScript proj = Instantiate(bulletPrefab);
            proj.gameObject.SetActive(false);
            bullets.Enqueue(proj);
        }
        return bullets.Dequeue();
    }

    public void ReturnToPool(BulletScript bullet)
    {
        bullet.gameObject.SetActive(false);
        bullets.Enqueue(bullet);
    }
}
