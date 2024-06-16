using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberTwo : MonoBehaviour
{
    [SerializeField] EventMaker EventMaker_Publisher;
    [SerializeField] Animator Animator_SubMember;


    private void OnEnable()
    {
        EventMaker_Publisher.Subscribe(isSubscribe: true, OnEventLalala);
    }

    private void OnDisable()
    {
        EventMaker_Publisher.Subscribe(isSubscribe: false, OnEventLalala);
    }
    public void OnEventLalala()
    {
        Animator_SubMember.SetTrigger("LevelUp");
    }
}
