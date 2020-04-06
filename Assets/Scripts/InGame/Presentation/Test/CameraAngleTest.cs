using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngleTest : MonoBehaviour
{
    Vector3 fuga;
    void Awake()
    {
        // Test(Vector2.zero);
        // Test(new Vector2(0, -89f));
        // Test(new Vector2(359f, 89f));
        // Test(new Vector2(-1f, -90f));
        // Test(new Vector2(360f, 90f));
        // Test(new Vector2(361f, 10000f));
        // Test(new Vector2(721f, -10000f));
        Fuga();
    }

    void Update()
    {
        // transform.position += hoge;
    }



    void Test(Vector2 value)
    {
        var hoge = new CameraAngle(value).value;
        Debug.Log($"{value}:{hoge}");
    }

    void Fuga ()
    {
        Hoge(0f, 0f, 1f);
        Hoge(90f, 0f, 1f);
        Hoge(180f, 0f, 1f);
        Hoge(360f, 0f, 1f);
        Hoge(361f, 0f, 1f);
        Hoge(-90f, 0f, 1f);
        Hoge(0f, 90f, 1f);
        Hoge(0f, -90f, 1f);
        Hoge(0f, 180f, 1f);
        Hoge(0f, 0f, 5f);
        // Hoge(0f, 0f, 1f);
        // Hoge(0f, 90f, 1f);
        // Hoge(0f, -90f, 1f);
        // Hoge(0f, 180f, 1f);
        // Hoge(0f, 200f, 1f);
        // Hoge(90f, 0, 1f);
        // Hoge(90f, 90f, 1f);
        // Hoge(0f, 0, 5f);
    }
    void Hoge(float x, float y, float r)
    {
        var result = new CameraAngle(new Vector2(x, y)).Hoge(r);
        Debug.Log($"x:{x} y:{y} r:{r} {result}");
    }
}