using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationSpeed
{
    const float min = 0;
    const float max = 360f;

    public readonly float value;

    public CameraRotationSpeed(float value){
        if(value < min) throw new ArgumentOutOfRangeException();
        if(value > max) throw new ArgumentOutOfRangeException();
        this.value = value;
    }
}