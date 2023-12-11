using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{

    public int MaxHealth;
    public int Health;
    public int Damage;
    public Score s;
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
            transform.GetComponent<Renderer>().material.color = Color.Lerp(Color.black, Color.white, healthNormalized);
            Destroy(collision.gameObject);

            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
