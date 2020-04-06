using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerPresenter : MonoBehaviour
{
    CharacterController charaControllerCache;

    void Awake()
    {
        charaControllerCache = GetComponent<CharacterController>(); ;
    }
    public void Move(Vector3 vector3)
    {
        charaControllerCache.Move(vector3);
    }
}