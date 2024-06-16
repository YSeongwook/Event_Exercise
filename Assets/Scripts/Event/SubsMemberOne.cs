using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberOne : MonoBehaviour
{
    [SerializeField] Animator Animator_SubMember;

    public void OnEventMakerInvoked()
    {
        Animator_SubMember.SetTrigger("Atk");
    }

}
