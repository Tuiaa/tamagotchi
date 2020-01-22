using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectHelper
{

    public GameObject GetReferenceToGameObject(string gameObjectName) {
        var foundGameObject = GameObject.Find(gameObjectName);

        if (foundGameObject != null) {
            return foundGameObject;
        } else {
            Debug.LogWarning("GameObjectHelper: Couldn't find reference to gameobject");
            return null;
        }
    }

    public Vector3 GetCurrentPositionOfGameObject(GameObject gameObject) {
        return gameObject.transform.position;
    }
}
