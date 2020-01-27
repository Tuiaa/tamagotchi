using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStatus : IPetStatus
{
    /*  GENERAL  */
    private string _name = GameConstants.CAT_DEFAULT_NAME;
    private float _hunger = 10f;
    private float _love = 10f;
    private float _sleep = 10f;
    private float _play = 10f;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public float Hunger
    {
        get { return _hunger; }
        set { _hunger = value; }
    }

    public float Love
    {
        get { return _love; }
        set { _love = value; }
    }

    public float Sleep
    {
        get { return _sleep; }
        set { _sleep = value; }
    }

    public float Play
    {
        get { return _play; }
        set { _play = value; }
    }
}
