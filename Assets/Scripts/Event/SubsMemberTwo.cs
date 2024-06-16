using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberTwo : MonoBehaviour
{
    [SerializeField] Animator Animator_SubMember;

    public void OnEventLalala()
    {
        Animator_SubMember.SetTrigger("LevelUp");
    }
}
