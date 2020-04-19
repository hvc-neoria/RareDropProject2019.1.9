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

    public AxisInput MainAxis() => new AxisInput(new Vector2(MainHorizontal(), MainVertical()));
    public AxisInput SubAxis() => new AxisInput(new Vector2(SubHorizontal(), SubVertical()));

    public bool Attack() => Input.GetButtonDown("Fire1");
}