using UnityEngine;

/*
 *      Makes UI element follow a gameobject
 *      - Used for making status text follow cat
 */
public class UiToFollowGameObject : MonoBehaviour
{
    [SerializeField] private Transform _gameObjectToBeFollowed;
    [SerializeField] private RectTransform _rectTransform;

    private void Update() {
        if(_gameObjectToBeFollowed == null || _rectTransform == null)
        {
            Debug.LogWarning("UiToFolowGameObject: Missing references");
            return;
        }

        var pos = Camera.main.WorldToScreenPoint(_gameObjectToBeFollowed.position);
        _rectTransform.position = pos;
    }
}