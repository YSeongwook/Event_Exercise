using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMaker : MonoBehaviour
{
    [SerializeField] Animator Animator_Player;

    public delegate void ImDelegate();
    ImDelegate _delegate;

    private void Start()
    {
    }

    // 보통 Subscribe보다 Register 또는 AddEvent 등의 용어를 쓴다 - 예제는 구독이라는 의미로 그냥 사용
    public void Subscribe(bool isSubscribe, ImDelegate callback)
    {
        if (isSubscribe)
            _delegate += callback;
        else
            _delegate -= callback;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeEvent();
        }
    }

    private void InvokeEventTwo()
    {
        Animator_Player.SetTrigger("LevelUp");
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");
        _delegate();
        //_delegate.Invoke();
    }
}
