using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject TargetPoint;
    public NavMeshAgent Agent;



   


    
    public void SetTarget(Vector3 target)
    {
    Agent.destination = target;
}
}
