using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{


    public float currentHealth;
    public Slider healthSlider;
    public Image damage;
    public float flash = 4f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public bool isDead;
    bool damaged;

    // Use this for initialization
    void Awake()
    {
        currentHealth = GetComponent<PlayerAttributes>().Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (damaged)
        {
            damage.color = flashColour;
        }
        else
        {
            damage.color = Color.Lerp(damage.color, Color.clear, flash * Time.deltaTime);
        }
        damaged = false;
    }

    public void takeDamage(float amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if (currentHealth <= 5 && !isDead)
        {
            healthSlider.value = 0;
            Death();
        }
    }

    void Death(){
        isDead = true;
    }
}