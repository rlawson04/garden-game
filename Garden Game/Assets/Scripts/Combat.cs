using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    // Add animator later
    //public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Mouse0))
       {
            Attack();
       } 
    }

    void Attack()
    {
        //play attack animation
        //animator.SetTrigger("Attack");

        // detect enemy 
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider collider in hitEnemies)
        { 
            collider.gameObject.SetActive(false);
        }
        // apply damage
    }
}
