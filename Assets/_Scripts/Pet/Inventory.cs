using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *      INVENTORY
 *      - Has list of all owned items
 *      - Can later be queried so we get for example all decorations
 *        or consumable items
 *      - Items are still WIP so not fully designed what it does and how
 * 
 */
public class Inventory
{
    private List<IItem> _ownedItems = new List<IItem>();

    public void AddItemToOwnedItemsList(IItem boughtItem)
    {
        _ownedItems.Add(boughtItem);
    }

    public List<IItem> GetAllOwnedItems()
    {
        return _ownedItems;
    }
}
