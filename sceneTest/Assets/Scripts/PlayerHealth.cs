using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            takeDamage(10);

            healthBar.setHealth(currentHealth);
            Debug.Log(currentHealth);
        }
        if(currentHealth == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void takeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void OnTriggerEnter(Collider Col)
    {
        /*if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Touching enemy");
            takeDamage(10);
        }*/
         if(Col.gameObject.tag == "Enemy")
        {
            Debug.Log("Touching Enemy, Spikes hurt, move away | -10 HP ");
            takeDamage(10);
            healthBar.setHealth(currentHealth);
        }
         if(Col.gameObject.tag == "Water")
        {
            Debug.Log("Touching Water, swim up. | -50 HP ");
            takeDamage(50);
            healthBar.setHealth(currentHealth);
        }
    }

}
