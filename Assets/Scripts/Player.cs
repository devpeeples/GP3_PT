using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    
    public HealthBar healthBar;

    public int maxCharge = 10;
    public int currentCharge;

    public ChargeBar chargeBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentCharge = maxCharge;
        chargeBar.SetMaxCharge(maxCharge);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            UseCharge(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void UseCharge(int used)
    {
        currentCharge -= used;

        chargeBar.SetCharge(currentCharge);
    }
}
