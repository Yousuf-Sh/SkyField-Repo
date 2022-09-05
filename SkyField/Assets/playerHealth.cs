using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
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
            takeDamage(10);
        }

    }
    void takeDamage(int damageAmmount)
    {
        currentHealth -= damageAmmount;
        healthbar.setHealth(currentHealth);
    }
}
