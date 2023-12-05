using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaundCube : MonoBehaviour
{
   public GameObject SpawnPoint;
   public GameObject SpawnObject;
   public float Scale;
   public void AddCube()
   {
     GameObject cube = Instantiate(SpawnObject, SpawnPoint.transform.position,Quaternion.identity);
        cube.transform.localScale = cube.transform.localScale * Scale;
   }

}
