using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerExample : MonoBehaviour
{
    // //Base stats and properties
    // private float healtPoint = 50f;
    // private float damagePoint = 10f;
    // private float speed = 5f;
    // public float Health { get { return healtPoint; } set { healtPoint = value; } }
    // public float Damage { get { return damagePoint; } set { damagePoint = value; } }
    // public float MovementSpeed { get { return speed; } set { speed = value; } }

    // private Animator anim;
    // private PlayerController player;
    // private Vector3 offset = new Vector3(0, 1.5f, -1f);
    // private Vector3 playerPos;

    // public bool isDead = false;

    // private void Awake()
    // {
    //     Health = 50f;
    //     Damage = 10f;
    //     MovementSpeed = 5f;
    //     isDead = false;
    // }
    // private void Start()
    // {
    //     anim = GetComponent<Animator>();
    //     player = FindObjectOfType<PlayerController>();
    //     playerPos = player.transform.position - offset;
    // }
    // private void Update()
    // {
    //     //movement logic
    //     transform.position += transform.forward * MovementSpeed * Time.deltaTime;
    //     anim.SetBool("move", true);

    //     //if the player is nearby, then the monster will go to the player
    //     if (PlayerNearby(10f))
    //     {
    //         transform.position = Vector3.MoveTowards(transform.position, playerPos, MovementSpeed * Time.deltaTime);
    //         transform.LookAt(playerPos);
    //         //check that the enemy can attack, if yes:
    //         if (PlayerNearby(5f))
    //         {
    //             //attack player, play the attack animation
    //             StartCoroutine(AttackPlayer());
    //         }
    //     }

    //     //check the enemy is dead
    //     if (Health <= 0)
    //     {
    //         isDead = true;
    //         MonsterDied();
    //     }
    // }
    // IEnumerator AttackPlayer()
    // {
    //     anim.SetBool("attack", true);
    //     yield return new WaitForSeconds(1);
    //     Destroy(gameObject, 1);
    // }

    // private void MonsterDied()
    // {
    //     GetComponentInChildren<MeshCollider>().enabled = false;
    //     anim.SetTrigger("dead");
    //     Destroy(gameObject, 1);
    // }

    // private bool PlayerNearby(float value)
    // {
    //     return Vector3.Distance(transform.position, player.transform.position) <= value;
    // }
}
