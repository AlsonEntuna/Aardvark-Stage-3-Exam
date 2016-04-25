using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public float MaxHealth;

    private float currentHealth;

    public bool IsAlive
    {
        get
        {
            return currentHealth > 0;
        }
    }

    void Start()
    {
        currentHealth = MaxHealth;
    }

    void Update()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, MaxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }
}
