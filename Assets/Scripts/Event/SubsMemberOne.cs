using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberOne : MonoBehaviour
{
    [SerializeField] EventMaker EventMaker_Publisher;
    [SerializeField] Animator Animator_SubMember;

    private void OnEnable()
    {
        EventMaker_Publisher.Subscribe(isSubscribe:true, OnEventMakerInvoked);
    }

    private void OnDisable()
    {
        EventMaker_Publisher.Subscribe(isSubscribe:false, OnEventMakerInvoked);
    }

    public void OnEventMakerInvoked()
    {
        Animator_SubMember.SetTrigger("Atk");
    }

}
