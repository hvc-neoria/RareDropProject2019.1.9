using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngle
{
    const float minX = 0;
    const float maxX = 360f;
    const float minY = -89f;
    const float maxY = 89f;

    public readonly Vector2 value;

    public CameraAngle(Vector2 value){
        if (value.x < minX)
        {
            var fromZeroToMinus360 = value.x %= maxX;
            value.x = fromZeroToMinus360 + maxX;
        }
        if(value.x >= maxX) value.x %= maxX;
        if(value.y < minY) value.y = minY;
        if(value.y > maxY) value.y = maxY;
        this.value = value;
    }

    public CameraAngle Add(CameraAngle cameraAngle)
    {
        var result = this.value + cameraAngle.value;
        return new CameraAngle(result);
    }

    public Vector3 Hoge(float radius)
    {
        // xを加算で反時計回り、原点を負のZ軸上に設定
        float newX = this.value.x * -1f - 180f;
        // yを加算でy上昇、原点をy=0に設定
        float newY = this.value.y * -1f + 90f;
        Vector3 fuga = ToSphericalCoordinate(new Vector2(newX, newY), radius);
        return fuga;
    }

    // Transform.RotateAroundではXの回転を制限するのが困難なため、こちらが有効
    // radiusを加算するとyが加算される
    // yを加算するとz方向を経由してyが減算される
    // xを加算するとy軸で時計回りする
    Vector3 ToSphericalCoordinate(Vector2 vector2, float radius)
    {
        float xRad = vector2.x * Mathf.Deg2Rad;
        float yRad = vector2.y * Mathf.Deg2Rad;
        Vector3 result = new Vector3(
            radius * Mathf.Sin(yRad) * Mathf.Sin(xRad),
            radius * Mathf.Cos(yRad),
            radius * Mathf.Sin(yRad) * Mathf.Cos(xRad)
        );
        return result;
    }


    public CameraAngle Multi(MoveSpeed speed)
    {
        var result = this.value * speed.value;
        return new CameraAngle(result);
    }

    // todo rename かける1可変フレームの時間 MultiDynamicFrameTime?
    public CameraAngle MultiDeltaTime()
    {
        var result = this.value * Time.deltaTime;
        return new CameraAngle(result);
    }

    // 斜めを丸くする
}