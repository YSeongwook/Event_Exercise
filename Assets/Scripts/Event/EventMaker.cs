using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMaker : MonoBehaviour
{
    [SerializeField] SubsMemberOne Member_One;
    [SerializeField] SubsMemberTwo Member_Two;
    [SerializeField] Animator Animator_Player;

    delegate void ImDelegate();
    ImDelegate _customDelegate;

    Action<int> _customAction;
    Func<int> _customFunc;
    Func<int, string, bool> _specialFunc;

    private void Start()
    {
        _customDelegate = new ImDelegate(InvokeEvent);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _customAction = InvokeEventThree;


            _customAction.Invoke(100);


            _customFunc = InvokeEventFour;
            int result = _customFunc.Invoke();

            _specialFunc = SpecialFunc;
            
            if(_specialFunc(8, "안녕"))
            {
                Debug.Log("오~");
            }

            //_customDelegate = InvokeEventTwo;
            //InvokeEvent();
            //_customDelegate();
        }
    }

    private bool SpecialFunc(int number, string bText)
    {
        return (number < 10) && (bText == "안녕");
    }

    private int InvokeEventFour()
    {
        return 10;
    }

    private void InvokeEventThree(int abc)
    {
    }

    private void InvokeEventTwo()
    {
        Animator_Player.SetTrigger("LevelUp");
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");

        if (Member_One)
            Member_One.OnEventMakerInvoked();

        if (Member_Two)
            Member_Two.OnEventLalala();
    }
}
