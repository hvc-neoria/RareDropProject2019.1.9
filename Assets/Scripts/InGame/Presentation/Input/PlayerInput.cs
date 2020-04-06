using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput
{
    float MainHorizontal() => Input.GetAxis("Horizontal");
    float MainVertical() => Input.GetAxis("Vertical");
    float SubHorizontal() => Input.GetAxis("SubHorizontal");
    float SubVertical() => Input.GetAxis("SubVertical");

    public Vector2 MainAxis() => new Vector2(MainHorizontal(), MainVertical());
    public Vector2 SubAxis() => new Vector2(SubHorizontal(), SubVertical());
}