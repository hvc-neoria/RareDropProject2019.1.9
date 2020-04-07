using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Neoria.InGame.Domain.Player;

public class PlayerMovePresenter : MonoBehaviour
{
    CharacterControllerPresenter charaPresenter;
    Transform cameraTransformCache;

    void Awake()
    {
        charaPresenter = GetComponent<CharacterControllerPresenter>();
        cameraTransformCache = Camera.main.transform;
    }

    void Update()
    {
        var input = new PlayerInput();
        AxisInput axisInput = input.MainAxis();

        MoveSpeed speed = new MoveSpeed(3f);
        Vector3 cameraForward = cameraTransformCache.forward;

        MoveVector2 moveVector = new MoveVector2(axisInput.value);
        Vector3 vector3 = moveVector
            .Multi(speed)
            .MultiCurrentFrameTime()
            .RotateTo(cameraForward)
            .ToXZOfVector3();

        charaPresenter.Move(vector3);
    }
}