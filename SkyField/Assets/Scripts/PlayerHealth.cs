using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int damageAmmount;
    public healthBar healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(damageAmmount);
        }

    }
   
    void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.setHealth(currentHealth);
    }
}
