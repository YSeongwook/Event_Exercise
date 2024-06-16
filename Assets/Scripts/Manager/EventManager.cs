using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class EventManager
{
    private static EventManager _instance = null;

    private EventMaker _currentEventMaker;


    public static EventManager Inst
    {
        get
        {
            if (_instance == null)
            {
                _instance = new EventManager();
            }
            return _instance;
        }
    }

    public void RegisterCurEventMaker(bool isRegister, EventMaker eventManer)
    {
        if (isRegister)
            _currentEventMaker = eventManer;
        else
        {
            _currentEventMaker = null;
        }
    }

    public void RequestSubscribe(bool isSubscribe, Action callback)
    {
        if(_currentEventMaker == null)
        {
            return;
        }

        _currentEventMaker.Subscribe(isSubscribe, callback);
    }
}
