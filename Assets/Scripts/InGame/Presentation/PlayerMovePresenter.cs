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
        // TODO インプットのターゲット状態を作成
        var input = new PlayerInput();

        // presenterの値をドメイン用に変換
        // TODO:inputVector2を型にするか
        MoveVector2 inputVector = new MoveVector2(input.MainAxis());
        MoveSpeed speed = new MoveSpeed(3f);
        Vector3 cameraForward = cameraTransformCache.forward;

        Vector3 vector3 = inputVector.Move(speed, cameraForward);
        charaPresenter.Move(vector3);
    }
}