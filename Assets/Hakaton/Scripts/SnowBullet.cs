using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBullet : MonoBehaviour
{
    public float Impulse = 5f;
    public float LifeTime = 3f;

    private float _Timer;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * Impulse, ForceMode.Impulse);
    }

    private void Update()
    {
        _Timer += Time.deltaTime;
        if (_Timer > LifeTime)
        {
            Destroy(gameObject);
        }
    }
}
