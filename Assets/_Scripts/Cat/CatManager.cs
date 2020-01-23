using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    /*  GENERAL */
    [SerializeField] private GameObject _cat;

    /*  SAVING  */
    private GameSaveManager _gameSaveManager = new GameSaveManager();
    private CatStatus _catStatus = new CatStatus();
    
    void Start()
    {
        _gameSaveManager.LoadCatStateFromPlayerPrefs(_catStatus);
        Debug.Log("cat name: " + _catStatus.Name);
    }

    void Update()
    {
        
    }
}
