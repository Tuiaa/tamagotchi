using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<IItem> _ownedItems;

    public void AddItemToOwnedItemsList(IItem boughtItem)
    {
        _ownedItems.Add(boughtItem);
    }

    public List<IItem> GetAllOwnedItems()
    {
        return _ownedItems;
    }

    public List<IConsumable> GetAllConsumableItems()
    {
        
    }
}
