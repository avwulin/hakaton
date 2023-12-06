using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{

    public GameObject Snowball;
    public GameObject SnowPoint;
    public bool IsShoot;

    void Update()
    {
        if (IsShoot == true)
        {
            GameObject Snow = Instantiate(Snowball, SnowPoint.transform.position, SnowPoint.transform.rotation);
            Snow.AddComponent<SnowBullet>();
            IsShoot = false;
        }
    }

    public void Shoot()
    {
        IsShoot = true;
    }

    public void StopShoot()
    {
        IsShoot = false;
    }
}
