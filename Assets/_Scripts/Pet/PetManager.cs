using UnityEngine;

/*
 *      PER MANAGER
 *      - Handles everything pet related
 * 
 */
public class PetManager : MonoBehaviour
{
    /*  GENERAL */
    [SerializeField] private GameObject _pet;
    private PetStatus _petStatus = new PetStatus();

    public IPetStatus GetCurrentPetState() {
        return _petStatus;
    }
}
