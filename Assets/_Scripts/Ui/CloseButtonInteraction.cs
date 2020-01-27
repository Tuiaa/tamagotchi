using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _uiParent;

    public void Interact()
    {
        if(_uiParent != null)
        {
            _uiParent.SetActive(false);
        }
    }
}
