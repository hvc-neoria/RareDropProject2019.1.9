using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeed
{
    const float min = 0;
    const float max = 10f;

    public readonly float value;

    public MoveSpeed(float value){
        if(value < min) throw new ArgumentOutOfRangeException();
        if(value > max) throw new ArgumentOutOfRangeException();
        this.value = value;
    }
}