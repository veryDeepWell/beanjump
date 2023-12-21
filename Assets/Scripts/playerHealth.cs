using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public AudioSource takeDamage;

    public Text healthText;

    public float currentHealth;
    public float maxHealth = 5;

    private void Start()
    {
        currentHealth = maxHealth;

        healthText.text = "";
        healthText.text += "HP:" + currentHealth.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemyBullet")
        {
            Debug.Log("player.hit.trigger");
            Destroy(other.gameObject);
            takeDamage.Play();
            currentHealth--;

            healthText.text = "";
            healthText.text += "HP:" + currentHealth.ToString();

            if (currentHealth <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
