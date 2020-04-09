using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Neoria.InGame.Domain.Player;

public class Sandbox : MonoBehaviour
{
    [SerializeField] Vector2 vector2;
    [SerializeField] float num;

    void Start()
    {

    }

    void Update()
    {

    }

    void DownKeyCheck()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(code))
                {
                    //処理を書く
                    Debug.Log(code);
                    break;
                }
            }
        }
    }
}