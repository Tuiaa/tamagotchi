using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour, IInteractable, IItem
{
    [SerializeField] private GameObject _diaryUIElements;

    public void Interact()
    {
        if(_diaryUIElements != null)
        {
            _diaryUIElements.SetActive(true);
        }
    }

    public void AddCount()
    {
        throw new System.NotImplementedException();
    }

    public void DeductCount()
    {
        throw new System.NotImplementedException();
    }

    public void GetCount()
    {
        throw new System.NotImplementedException();
    }

    public GameObject GetGameObjectReference()
    {
        return gameObject;
    }
}
