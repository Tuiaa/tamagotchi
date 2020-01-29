using UnityEngine;

/*
 *  GAME SAVE MANAGER
 *  - Saves the current state of a pet
 *  - Currently uses PlayerPrefs but will change into another system
 *    later when saving all items the player has bought
 * 
 */
public class GameSaveManager
{
    /*  EVENTS  */
    public delegate void PetStateSavedEventHandler(IPetStatus petStatus);
    public static event PetStateSavedEventHandler PetStateSaved;

    public void SavePetStateToPlayerPrefs(IPetStatus petStatus) {
        PlayerPrefs.SetString(GameConstants.SAVE_FILE_CAT_NAME_KEY, petStatus.Name);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_HUNGER_KEY, petStatus.Hunger);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_LOVE_KEY, petStatus.Love);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_PLAY_KEY, petStatus.Play);
        PlayerPrefs.SetFloat(GameConstants.SAVE_FILE_CAT_SLEEP_KEY, petStatus.Sleep);

        PlayerPrefs.Save();
        PetStateSaved?.Invoke(petStatus);
    }

    public void LoadPetStateFromPlayerPrefs(IPetStatus petStatus) {

        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_NAME_KEY)) {
            petStatus.Name = PlayerPrefs.GetString(GameConstants.SAVE_FILE_CAT_NAME_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_HUNGER_KEY)) {
            petStatus.Hunger = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_HUNGER_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_LOVE_KEY)) {
            petStatus.Love = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_LOVE_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_PLAY_KEY)) {
            petStatus.Play = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_PLAY_KEY);
        }
        if(PlayerPrefs.HasKey(GameConstants.SAVE_FILE_CAT_SLEEP_KEY)) {
            petStatus.Sleep = PlayerPrefs.GetFloat(GameConstants.SAVE_FILE_CAT_SLEEP_KEY);
        }
    }
}