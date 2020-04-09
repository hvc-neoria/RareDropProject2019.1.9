using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisInput
{
    const float min = -1f;
    const float max = 1f;

    public readonly Vector2 value;

    public AxisInput(Vector2 value){
        if(value.x < min) throw new ArgumentOutOfRangeException();
        if(value.y > max) throw new ArgumentOutOfRangeException();
        this.value = value;
    }
}