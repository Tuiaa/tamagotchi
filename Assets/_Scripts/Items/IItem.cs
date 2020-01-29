using UnityEngine;

public interface IItem
{
    void GetCount();
    void AddCount();
    void DeductCount();
    GameObject GetGameObjectReference();
}
