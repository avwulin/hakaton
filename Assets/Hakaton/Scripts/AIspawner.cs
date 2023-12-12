using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIspawner : MonoBehaviour
{
    public GameObject AIPrefab;
    public GameObject TargerPoint;
    public float Delay;
    private float _timer;
    public Score score;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > Delay)
        {
            GameObject npc = Instantiate(AIPrefab, transform.position, transform.rotation);
            npc.GetComponent<AI>().SetTarget(TargerPoint);
            npc.GetComponent<DamageSystem>().score=score;
            _timer = 0f;

        }
    }
}
