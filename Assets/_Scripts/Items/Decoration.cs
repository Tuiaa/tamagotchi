using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *      DECORATION
 *      - All decorative items that can be bought from shop
 *      - Still WIP, need to design how the shop would actually work
 *      - Items are still WIP so not fully designed what it does and how
 * 
 */
public class Decoration : MonoBehaviour, IDecoration, IItem
{
    public void Display()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public GameObject GetGameObjectReference()
    {
        return gameObject;
    }
}
