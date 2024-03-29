using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] Animator animator;
    int currentHealth;
    

    // Update is called once per frame
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Play hurt animation

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died"); 

        // Die animation
        animator.SetBool("IsDead", true);

        // Disable
        GetComponent<CapsuleCollider>().enabled = false;
        this.enabled = false;
        
    }
}
