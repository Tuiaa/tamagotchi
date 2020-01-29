using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _uiToHide;

    public void Interact()
    {
        if(_uiToHide != null)
        {
            _uiToHide.SetActive(false);
        }
    }
}
