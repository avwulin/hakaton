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

    
    public Score score;
    private void Start()
    {
        Health = MaxHealth;
       
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
                if (score)
                {
                    score.ScoreUI = Score;
                }
             
                // Уничтожение объекта и добавление очков
                Destroy(gameObject);
            }
        }
    }
}