using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBowl : MonoBehaviour, IInteractable, IItem
{
    [SerializeField] private GameObject _foodSprite;

    // If food bowl is tapped, it should always fill the food
    // Food bowl doesn't care if there's food left in inventory or not
    public void Interact()
    {
        if (_foodSprite != null)
        {
            _foodSprite.SetActive(true);
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
