using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaundCube : MonoBehaviour
{
   public GameObject SpawnPoint;
   public GameObject SpawnObject;
   public void AddCube()
   {
      Instantiate(SpawnObject, SpawnPoint.transform.position,Quaternion.identity);
   }

}
