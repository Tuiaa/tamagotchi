using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory
{
    private List<Transform> _ownedItems = new List<Transform>();

    public void AddItemToOwnedItemsList(Transform boughtItem)
    {
        _ownedItems.Add(boughtItem);
    }

    public List<Transform> GetAllOwnedItems()
    {
        return _ownedItems;
    }

   /* public List<Transform> GetAllConsumableItems()
    {
        foreach (var item in _ownedItems)
        {
            if(item is IDecoration)
            {

            }
        }
    }*/
}
