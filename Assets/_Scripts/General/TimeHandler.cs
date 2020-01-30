using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeHandler
{
    private DateTime _currentTime = DateTime.Now;
    private int _currentHour = 0;
    private int _currentMinute = 0;
    private string _format = "HH:mm";

    public TimeHandler()
    {
        UpdateCurrentTime();
    }

    public void UpdateCurrentTime()
    {
        var timeNow = DateTime.Now;

        _currentHour = timeNow.Hour;
        _currentMinute = timeNow.Minute;
    }

    public DateTime GetCurrentTime()
    {
        return _currentTime;
    }
}
