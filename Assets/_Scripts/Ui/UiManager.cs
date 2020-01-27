using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    /*  DIARY   */
    private DiaryUpdater _diaryUpdater = new DiaryUpdater();
    [SerializeField] private List<Text> _diaryUiFields;

    void Awake()
    {
        RegisterEvents();
    }

    public void UpdateDiaryValues(IPetStatus petStatus) {
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

    public void RegisterEvents() {
        GameSaveManager.PetStateSaved += UpdateDiaryValues;
    }

    public void UnRegisterEvents() {
        GameSaveManager.PetStateSaved -= UpdateDiaryValues;
    }
}
