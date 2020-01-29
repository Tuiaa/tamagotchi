using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration : MonoBehaviour, IDecoration, IItem
{

    public void Display()
    {
        gameObject.SetActive(true);
    }

    public void Remove()
    {
        gameObject.SetActive(false);
    }

    public void GetCount()
    {
        throw new System.NotImplementedException();
    }

    public void AddCount()
    {
        throw new System.NotImplementedException();
    }

    public void DeductCount()
    {
        throw new System.NotImplementedException();
    }

    public GameObject GetGameObjectReference()
    {
        return gameObject;
    }
}
