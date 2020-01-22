using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 *      Makes UI element follow a gameobject
 *      - Used for making status text follow cat
 */
public class UiToFollowGameObject : MonoBehaviour
{
    [SerializeField] private Transform _gameObjectToBeFollowed;
    [SerializeField] private RectTransform _rectTransform;

    private void Update() {
        if(_gameObjectToBeFollowed == null) return;

        var pos = Camera.main.WorldToScreenPoint(_gameObjectToBeFollowed.position);
        _rectTransform.position = pos;
    }
}