using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    public float score;

    private void Start()
    {
        health = maxHealth;
        score = 0;
    }

    private void takeDamage(float damage)
    {
        health -= damage;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<AiController>(out AiController controller))
        {
            takeDamage(controller.attack);
        }
    }
}
