using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovePresenter : MonoBehaviour
{
    Transform transformCache;
    Transform playerTransformCache;

    const float height = 1.5f;
    const float distance = 5f;

    CameraAngle cameraAngle = new CameraAngle(Vector2.zero);

    void Awake()
    {
        transformCache = transform;
        playerTransformCache = GameObject.FindWithTag("Player").transform;
        
    }

    void LateUpdate()
    {
        // TODO インプットのターゲット状態を作成
        PlayerInput input = new PlayerInput();
        Vector2 moveVector2 = input.SubAxis();
        var result = cameraAngle.Add(new CameraAngle(moveVector2));//new CameraAngle(moveVector2).Hoge(5f);
        cameraAngle = result;
        Debug.Log(result.value);
        transformCache.position = result.Hoge(5f);
        // Debug.Log($"{}");
        // moveVector2 = Vector2.one;
        // var hoge = prevPosition;

        // var playerPos = playerTransformCache.position;
        // var point = playerPos + Vector3.up * height;

        // vector2球座標をnormalizeした向きVector3に。

        // # 移動
        // var fuga = new CameraRotate();
        // fuga.RotateAroundCommand(transformCache, point, moveVector2);

        // # 追従
        // Vector3 <- 
        // Vector3 directionState = Vector3.forward * -1f;
        // Vector3 result = playerTransformCache.position + Vector3.up * height + direction * distance;
        // transformCache.position = result;

        // prevPosition = 
        // // presenterの値をドメイン用に変換
        // Vector2 vector2 = new Vector2(h, v);
        // MoveVector2 moveVector2 = new MoveVector2(vector2);
        // MoveSpeed speed = new MoveSpeed(3f);
        // moveVector2 = moveVector2.Move(speed, cameraTransformCache.forward);

        // // presenter用変換
        // var vector3ByCharaCon = new Vector3(moveVector2.value.x, 0, moveVector2.value.y);
        // charaPresenter.Hoge(vector3ByCharaCon);
    }

    
}