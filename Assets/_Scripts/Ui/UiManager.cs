using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 *      UI MANAGER
 *      - Currently handles all changes in UI's
 *      - Will refactor later so that differet UI's get updated from other
 *        classes handled by UiManager (will do for now until I get
 *        the project started)
 * 
 */
public class UiManager : MonoBehaviour
{
    /*  MANAGERS  */
    [SerializeField] private PetManager _petManager;

    /*  DIARY   */
    [SerializeField] private GameObject _diaryUiParent;
    [SerializeField] private List<Text> _diaryUiFields;

    /*   PET ACTIVITY STATUS TEXT    */
    [SerializeField] private Text _petActivityStatusText;

    void Awake()
    {
        RegisterEvents();
    }

    void OnDestroy()
    {
        UnRegisterEvents();
    }

    private void UpdateAndDisplayDiary()
    {
        if (_petManager == null || _diaryUiParent == null)
        {
            Debug.LogWarning("UiManager: Missing references");
            return;
        }

        UpdateDiaryValues(_petManager.GetCurrentPetState());
        _diaryUiParent.SetActive(true);
    }

    private void UpdateDiaryValues(IPetStatus petStatus)
    {
        if (_diaryUiFields.Count > 0)
        {
            foreach (Text value in _diaryUiFields)
            {
                if (value.name.Equals(GameConstants.DIARY_LOVE_VALUE_STRING)) value.text = petStatus.Love.ToString();
                if (value.name.Equals(GameConstants.DIARY_HUNGER_VALUE_STRING)) value.text = petStatus.Hunger.ToString();
                if (value.name.Equals(GameConstants.DIARY_SLEEP_VALUE_STRING)) value.text = petStatus.Sleep.ToString();
                if (value.name.Equals(GameConstants.DIARY_PLAY_VALUE_STRING)) value.text = petStatus.Play.ToString();
            }
        }
    }

    private void UpdatePetActivityStatusText(Activity activityStatus)
    {
        if (_petActivityStatusText == null)
        {
            Debug.LogWarning("UiManager: Missig references");
            return;
        }

        switch(activityStatus)
        {
            case Activity.Walking:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_WALKING_STRING;
                return;
            case Activity.Sleeping:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_SLEEPING_STRING;
                return;
            case Activity.Eating:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_EATING_STRING;
                return;
            case Activity.Playing:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_PLAYING_STRING;
                return;
            case Activity.Sitting:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_SITTING_STRING;
                return;
            case Activity.Messing:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_MESSING_STRING;
                return;
            default:
                _petActivityStatusText.text = GameConstants.PET_ACTIVITY_DEFAULT_STRING;
                return;
        }
    }

    private void RegisterEvents()
    {
        Diary.DiaryClicked += UpdateAndDisplayDiary;
        PetActivity.PetBehaviorChanged += UpdatePetActivityStatusText;
    }

    private void UnRegisterEvents()
    {
        Diary.DiaryClicked -= UpdateAndDisplayDiary;
        PetActivity.PetBehaviorChanged -= UpdatePetActivityStatusText;
    }
}
