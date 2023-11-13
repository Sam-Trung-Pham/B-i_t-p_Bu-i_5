using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
   
    //public HealthBar healthBar;
    public float speed = 2;
    int dir=1;
    public Transform rightCheck;
    public Transform leftCheck;
    void FixedUpdate()
    {
        if (gameObject.name.Equals("Circle"))
        {
            transform.Translate(Vector2.right * speed * dir * Time.fixedDeltaTime);
            if (Physics2D.Raycast(rightCheck.position, Vector2.down,2)==false)
            {
                dir = -1;
            }
            if (Physics2D.Raycast(leftCheck.position, Vector2.down,2)==false)
            {
                dir = 1;
            }
        }
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="HinhVuong")
        {
            TakeDamamge(20);
            Destroy(other.gameObject);
        }
    }

    void TakeDamamge(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
