using UnityEngine;

public class PetManager : MonoBehaviour
{
    //public delegate void CatStateSavedEventHandler();
   // public static event CatStateSavedEventHandler CatStateSaved;
    /*  GENERAL */
    [SerializeField] private GameObject _cat;

    /*  SAVING  */
    private readonly GameSaveManager _gameSaveManager = new GameSaveManager();
    private CatStatus _catStatus = new CatStatus();
    
    void Start()
    {
        _gameSaveManager.LoadPetStateFromPlayerPrefs(_catStatus);
        Debug.Log("cat name: " + _catStatus.Name);
        _catStatus.Sleep = 5f;
        _gameSaveManager.SavePetStateToPlayerPrefs(_catStatus);

       // if(CatStateSaved != null) CatStateSaved();
    }

    void Update()
    {
        
    }

    public void GetCurrentCatState() {

    }
}
