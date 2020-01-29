using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _uiManager;
    [SerializeField] private List<Transform> _items;

    private Inventory _inventory = new Inventory();

    void Start()
    {
        if (_items.Count > 0)
        {


            foreach (var item in _items)
            {
                _inventory.AddItemToOwnedItemsList(item);
            }

            StartCoroutine(ExampleCoroutine());
        }
        else { Debug.Log("list is empty: count: " + _items.Count); }

    }

    void Update()
    {
        
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
       // _inventory.GetAllConsumableItems();
    }
}
