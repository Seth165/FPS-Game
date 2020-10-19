using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float health = 100;
    public float maxHealth = 100;

    public GameObject playerHealthBarUI;
    public Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        slider.value = CalculatePlayerHealth();
    }

    void Update()
    {
        slider.value = CalculatePlayerHealth();

        if(health < maxHealth)
        {
            playerHealthBarUI.SetActive(true);
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculatePlayerHealth()
    {
        return health / maxHealth;
    }
}
