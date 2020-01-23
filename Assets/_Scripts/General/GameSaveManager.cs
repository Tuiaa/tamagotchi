using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaveManager
{
    public void SaveCatStateToPlayerPrefs(CatStatus catStatus) {
        PlayerPrefs.SetString(GameConstants.SAVE_FILE_CAT_NAME_KEY, catStatus.Name);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_HUNGER_KEY, catStatus.Hunger);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_LOVE_KEY, catStatus.Love);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_PLAY_KEY, catStatus.Play);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_SLEEP_KEY, catStatus.Sleep);

        PlayerPrefs.Save();
    }

    public void LoadCatStateFromPlayerPrefs(CatStatus catStatus) {

        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_NAME_KEY)) {
            catStatus.Name = PlayerPrefs.GetString(GameConstants.SAVE_FILE_CAT_NAME_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_HUNGER_KEY)) {
            catStatus.Hunger = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_HUNGER_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_LOVE_KEY)) {
            catStatus.Love = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_LOVE_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_PLAY_KEY)) {
            catStatus.Play = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_PLAY_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_SLEEP_KEY)) {
            catStatus.Sleep = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_SLEEP_KEY);
        }
    }
}
