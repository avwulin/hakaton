using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{
    public int MaxHealth;
    public int Health;
    public int Damage;
    public int Score; // Новая переменная для счетчика очков

    public Text scoreText; // Ссылка на текстовое поле для отображения счета

    private void Start()
    {
        Health = MaxHealth;
        Score = 0; // Инициализация счетчика очков
        UpdateScoreUI(); // Обновление UI счетчика очков
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Score.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Health -= Damage;
            float healthNormalized = (float)Health / MaxHealth;
            Renderer renderer = GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.material.color = Color.Lerp(Color.black, Color.white, healthNormalized);
            }

            Destroy(collision.gameObject);

            if (Health <= 0)
            {
                // Уничтожение объекта и добавление очков
                Destroy(gameObject);
                Score += 100;
                UpdateScoreUI();
            }
        }
    }
}