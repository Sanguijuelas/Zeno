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
    bool damaged;
    private UIController uiController;

    // Use this for initialization
    void Awake()
    {
        currentHealth = GetComponent<PlayerAttributes>().Health;
        uiController = GetComponent<UIController>();
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

    public void takeDamage(float amount, PlayerAttributes shooterAttributes)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if (currentHealth <= 5)
        {
            healthSlider.value = 0;
            Die();
            shooterAttributes.kills++;
        }
    }

    void Die()
    {
        GetComponent<PlayerAttributes>().deaths++;
        uiController.changeUI(UIController.GameUI.RESPAWN);
    }

    public void Respawn(){
        gameObject.transform.position = GetComponent<PlayerAttributes>().initial;
        currentHealth = 100;
        healthSlider.value = currentHealth;
        uiController.changeUI(UIController.GameUI.GAME);
    }
}