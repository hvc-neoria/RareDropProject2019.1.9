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
    CameraRotationSpeed speed = new CameraRotationSpeed(180f);

    CameraAngle prevCameraAngle = new CameraAngle(Vector2.zero);

    void Awake()
    {
        transformCache = transform;
        playerTransformCache = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
        PlayerInput input = new PlayerInput();
        AxisInput axisInput = input.SubAxis();

        DeltaCameraAngle deltaAngle = new DeltaCameraAngle(axisInput.value)
        .Multi(speed)
        .MultiCurrentFrameTime()
        .Reverse();

        CameraAngle currentCameraAngle = prevCameraAngle.Add(deltaAngle);
        prevCameraAngle = currentCameraAngle;

        Vector3 lookPoint = playerTransformCache.position + Vector3.up * height;
        Vector3 localPosition = currentCameraAngle.ToLocalPosition(distance);
        Vector3 position = lookPoint + localPosition;
        transformCache.position = position;

        transformCache.LookAt(playerTransformCache);
    }
}