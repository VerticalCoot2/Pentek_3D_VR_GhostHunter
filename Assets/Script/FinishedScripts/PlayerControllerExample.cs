using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControllerExample : MonoBehaviour
{
    // private static float healthPoint = 100f;
    // public static float Health { get { return healthPoint; } set { healthPoint = value; } }

    // public static int Score = 0;
    // public Text scoreText;

    // public float shootTime = 0.3f;
    // private float lastShootTime = 0;

    // private GvrReticlePointer aimCross;

    // public Transform firepoint;

    // private void Awake()
    // {
    //     Score = 0;
    //     Health = 100;
    // }
    // private void Start()
    // {
    //     aimCross = GetComponentInChildren<GvrReticlePointer>();
    // }
    // private void FixedUpdate()
    // {
    //     if (lastShootTime > Time.time - shootTime)
    //         return;
    //     var target = aimCross.CurrentRaycastResult;
    //     if (target.gameObject)
    //     {
    //         if (target.gameObject.tag == "Enemy")
    //         {
    //             Fire();
    //             lastShootTime = Time.time;
    //         }
    //     }
    // }
    // public void Fire()
    // {
    //     var projectile = ObjectPools.Instance.GetBullet();
    //     projectile.transform.position = firepoint.position;
    //     projectile.transform.rotation = Quaternion.Euler(90, 0, 0);
    //     projectile.gameObject.SetActive(true);
    //     projectile.GetComponent<Rigidbody>().velocity = Vector3.zero;
    //     projectile.GetComponent<Rigidbody>().AddForce(BulletController.bulletSpeed * firepoint.transform.forward);
    // }
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.GetComponent<Transform>().tag == "Enemy")
    //     {
    //         Health -= other.GetComponentInParent<EnemyController>().Damage;
    //     }
    //     if (Health <= 0)
    //         StartCoroutine(Restart());

    // }
    // IEnumerator Restart()
    // {
    //     FindObjectOfType<SpawnController>().gameObject.SetActive(false);
    //     scoreText.text = "Score: " + Score;
    //     scoreText.gameObject.SetActive(true);
    //     yield return new WaitForSeconds(3f);
    //     SceneManager.LoadScene("SampleScene");
    // }
}
