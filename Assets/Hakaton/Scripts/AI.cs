using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject TargetPoint;
    public NavMeshAgent Agent;





    public void Update()
    {
        Agent.destination = TargetPoint.transform.position;
    }

    public void SetTarget(GameObject target)
    {
    TargetPoint = target;
}
}
