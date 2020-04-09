using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position
{
    const float min = -1000f;
    const float max = 1000f;

    public readonly Vector3 value;

    public Position(Vector3 value){
        Vector3 result;
        result.x = Mathf.Clamp(value.x, min, max);
        result.y = Mathf.Clamp(value.y, min, max);
        result.z = Mathf.Clamp(value.z, min, max);
        this.value = result;
    }
}