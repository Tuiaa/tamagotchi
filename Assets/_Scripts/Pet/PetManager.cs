using UnityEngine;
using UniRx;
using System;

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

    /*   ACTIVITY    */
    private PetActivity _petActivity = new PetActivity();
    private IDisposable _disposable;
    private float _activityRandomizerInterval = 2f;


    void Start()
    {
        _disposable = Observable.Interval(TimeSpan.FromSeconds(_activityRandomizerInterval)).Subscribe(x =>
        {
            _petActivity.RandomizeNewActivity();
        });
    }

    void OnDestroy()
    {
        _disposable.Dispose();
    }

    public IPetStatus GetCurrentPetState() {
        return _petStatus;
    }
}
