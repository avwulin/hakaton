using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnowballController : MonoBehaviour
{
    private XRBaseInteractable _interactable;

    private void Start()
    {
      _interactable = GetComponent<XRBaseInteractable>();
      _interactable.selectExited.AddListener(OnObjectUngrabbed);
    }

    private void OnObjectUngrabbed(SelectExitEventArgs arg0)
    {
        gameObject.GetComponent<Collider>().enabled = true;
    }
}
