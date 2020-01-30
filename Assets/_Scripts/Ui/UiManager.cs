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


    void Awake()
    {
        RegisterEvents();
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

    private void RegisterEvents()
    {
        Diary.DiaryClicked += UpdateAndDisplayDiary;
    }

    private void UnRegisterEvents()
    {
        Diary.DiaryClicked -= UpdateAndDisplayDiary;
    }
}
