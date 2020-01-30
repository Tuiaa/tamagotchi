using UnityEngine;
using System.Collections.Generic;
using System.Collections;

/*
 *      Still WIP
 */
public class GameManager : MonoBehaviour
{
    private Inventory _inventory = new Inventory();
    private TimeHandler _timeHandler = new TimeHandler();

    void Start()
    {
        Debug.Log(_timeHandler.GetCurrentTime());
    }
}
