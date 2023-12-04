using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePaneli : MonoBehaviour
{
    public GameObject Panel;
    public void ActivateThis(){
        Panel.SetActive(!Panel.activeSelf);
    }
}
