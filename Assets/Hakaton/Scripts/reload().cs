using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reload : MonoBehaviour
{
    public GameObject SnowballPrefab;
    public GameObject SnowPoint;
    public bool IsShoot;

    private int ammoCount = 0;
    private const int maxAmmo = 50;
    private const int ammoPerSnowball = 5;

    public Text ammoText;

    

    void Update()
    {
        if (IsShoot && CanShoot())
        {
            ShootSnowball();
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Snowball"))
        {
            Destroy(collision.gameObject);
            Reload();
        }
    }

    void ShootSnowball()
    {
        GameObject snowball = Instantiate(SnowballPrefab, SnowPoint.transform.position, SnowPoint.transform.rotation);
        snowball.AddComponent<SnowBullet>();
        IsShoot = false;
        ConsumeAmmo();
    }

    void Reload()
    {
        int remainingAmmo = maxAmmo - ammoCount;
        int ammoToReload = Mathf.Min(remainingAmmo, ammoPerSnowball);

        if (ammoToReload > 0)
        {
            ammoCount += ammoToReload;
            Debug.Log("Оружие перезаряжено! Патроны: " + ammoCount);
            UpdateAmmoText();
        }
        else if(remainingAmmo > maxAmmo)
        {
            Debug.Log("Оружие полностью заряжено. Нельзя зарядить больше " + maxAmmo + " патронов.");
        }
    }

    void ConsumeAmmo()
    {
        ammoCount--;
        Debug.Log("Патрон использован. Осталось патронов: " + ammoCount);
        UpdateAmmoText();
    }

    bool CanShoot()
    {
        return ammoCount > 0;
    }

    void UpdateAmmoText()
    {
        ammoText.text = "Снаряды: " + ammoCount;
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
