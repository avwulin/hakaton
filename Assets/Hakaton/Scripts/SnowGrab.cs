using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnowGrab : MonoBehaviour
{
    private XRBaseInteractable _interactable;
    public GameObject snowball;
    private void Start()
    {
        _interactable = GetComponent<XRBaseInteractable>();
        _interactable.selectEntered.AddListener(OnObjectGrabbed);
        
    }
    private void OnObjectGrabbed(SelectEnterEventArgs arg0)
    {
        GameObject _snowballObject = Instantiate(snowball, arg0.interactor.transform.position, arg0.interactor.transform.rotation);
        XRBaseInteractable snowballInteractable = _snowballObject.GetComponent<XRBaseInteractable>();
        _interactable.interactionManager.ForceSelect(arg0.interactor, snowballInteractable);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Snowball"))
        {
            Destroy(collision.gameObject);
        }
        else
        {
            Physics.IgnoreCollision(GetComponent<Collider>(), collision.collider);
        }
    }
}
