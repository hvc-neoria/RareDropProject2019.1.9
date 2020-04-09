using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaCameraAngle
{
    const float min = -300f;
    const float max = 300f;

    public readonly Vector2 value;

    public DeltaCameraAngle(Vector2 value){
        Vector2 result;
        result.x = Mathf.Clamp(value.x, min, max);
        result.y = Mathf.Clamp(value.y, min, max);
        this.value = result;
    }

    public DeltaCameraAngle Multi(CameraRotationSpeed speed)
    {
        var result = this.value * speed.value;
        return new DeltaCameraAngle(result);
    }

    public DeltaCameraAngle MultiCurrentFrameTime()
    {
        var result = this.value * Time.deltaTime;
        return new DeltaCameraAngle(result);
    }

    public DeltaCameraAngle Reverse()
    {
        var result = -this.value;
        return new DeltaCameraAngle(result);
    }
}