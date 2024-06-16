using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class EventManager
{
    private static EventManager _instance = null;

    private EventMaker _currentEventMaker;
    private List<Action> _actionSubscribeRequestList = new List<Action>();


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
        {
            _currentEventMaker = eventManer;
            CheckSubscribeRequestList();
        }
        else
        {
            _currentEventMaker = null;
        }
    }

    private void CheckSubscribeRequestList()
    {
        if (_actionSubscribeRequestList.Count > 0)
        {
            foreach (var action in _actionSubscribeRequestList)
            {
                _currentEventMaker.Subscribe(true, action);
            }
            _actionSubscribeRequestList.Clear();
        }
    }

    public void RequestSubscribe(bool isSubscribe, Action callback)
    {
        if(_currentEventMaker == null)
        {
            _actionSubscribeRequestList.Add(callback);
            return;
        }

        _currentEventMaker.Subscribe(isSubscribe, callback);
    }
}
