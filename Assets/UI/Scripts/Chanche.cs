using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chanche : MonoBehaviour
{
    public SpaundCube Spawner;
    public Slider Slider;
  
    public void Chanches()
    {
        Spawner.Scale = Slider.value;
    }
    
}