using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float shootTime = 0.3f;
    private float lastShootTime = 0;

    private GvrReticlePointer aimCross;

    [SerializeField] private Transform firePoint;

    private void FixedUpdate()
    {
        if (lastShootTime > Time.time - shootTime) return;

        var target = aimCross.CurrentRaycastResult;
        if(target.gameObject.tag == "Enemy")
        {
            Fire();
            lastShootTime = Time.time;
        }
    }

    void Fire()
    {
        var projectile = ObjectPools.Instance.GetBullet();
        projectile.transform.position = firePoint.position;
        projectile.transform.rotation = Quaternion.Euler(90, 0, 0);
        projectile.gameObject.SetActive(true);
        projectile.GetComponent<Rigidbody>().velocity = Vector3.zero;
        projectile.GetComponent<Rigidbody>().AddForce(BulletScript.bulletSpeed * firePoint.transform.forward);
    }
}
