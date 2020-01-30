using System;
using System.Collections;
using System.Collections.Generic;

/*
 *      PET ACTIVITY
 *      - Class for randomizing what the pet is doing on idle state
 * 
 */
public enum Activity { Walking, Sleeping, Eating, Playing, Stretching, Sitting, Messing, IgnoredByUser };
public class PetActivity
{
    /*  EVENTS  */
    public delegate void PetBehaviorEventHandler(Activity activityStatus);
    public static event PetBehaviorEventHandler PetBehaviorChanged;

    /*  ACTIVITIES  */
    static Random _random = new Random();
    private Activity _currentActivity = Activity.Sitting;
    private List<Activity> _allActivities = new List<Activity> { Activity.Walking, Activity.Sleeping,
                                                                 Activity.Eating, Activity.Playing,
                                                                 Activity.Stretching, Activity.Sitting,
                                                                 Activity.Messing };

    public Activity GetCurrentActivity()
    {
        return _currentActivity;
    }

    // TODO: Make probabilities to each activity happening depending of a time of day
    // for example it's more probable to sleep during night
    public void RandomizeNewActivity()
    {
        var randomizedActivity = _random.Next(_allActivities.Count);
        _currentActivity = _allActivities[randomizedActivity];
        PetBehaviorChanged?.Invoke(_currentActivity);
    }
}
