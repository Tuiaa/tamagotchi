using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 *      DIARY
 *      - All actions diary gameobject on the scene is handling
 *      - Let's UI know when diary is opened
 *      - Currently diary is just a UI button on the scene, but will be changed 
 *        into a book or something similar thats displayed in the room
 * 
 */
public class Diary : MonoBehaviour, IInteractable, IItem
{
    /*  EVENTS  */
    public delegate void DiaryInteractionEventHandler();
    public static event DiaryInteractionEventHandler DiaryClicked;

    public void Interact()
    {
        DiaryClicked?.Invoke();
    }

    public GameObject GetGameObjectReference()
    {
        return gameObject;
    }
}
