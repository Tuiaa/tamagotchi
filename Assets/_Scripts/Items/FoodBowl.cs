using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *      FOOD BOWL
 *      - Interactive item which is used for feeding the pet
 *      - Fills the bowl with food when tapped
 *      - Items are still WIP so not fully designed what it does and how
 * 
 */
public class FoodBowl : MonoBehaviour, IInteractable, IItem
{
    [SerializeField] private GameObject _foodSprite;

    // At some point it should check if there's any food left in inventory
    // Still WIP so doesn't do the check yet
    public void Interact()
    {
        if (_foodSprite != null)
        {
            _foodSprite.SetActive(true);
        }
    }

    public GameObject GetGameObjectReference()
    {
        return gameObject;
    }
}
