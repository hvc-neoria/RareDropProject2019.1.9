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
        Vector2 result = value;
        if (value.x < minX)
        {
            float fromZeroToMinus360 = value.x % maxX;
            float fromZeroTo360 = fromZeroToMinus360 + maxX;
            result.x = fromZeroTo360;
        }
        if(value.x >= maxX) result.x = value.x % maxX;
        if(value.y < minY) result.y = minY;
        if(value.y > maxY) result.y = maxY;
        this.value = result;
    }

    public CameraAngle Add(DeltaCameraAngle deltaAngle)
    {
        var result = this.value + deltaAngle.value;
        return new CameraAngle(result);
    }

    public Vector3 ToLocalPosition(float radius)
    {
        // xを加算でy軸で反時計回り、x=0の時に負のZ軸上になるよう設定
        float newX = this.value.x * -1f - 180f;
        // yを加算でy上昇、y=0でy=0になるよう設定
        float newY = this.value.y * -1f + 90f;
        Vector3 result = ToSphericalCoordinate(new Vector2(newX, newY), radius);
        return result;
    }

    // y=0で上を向く
    // yを加算するとz方向を経由してyが減算される
    // xを加算するとy軸で時計回りする
    // Transform.RotateAroundでは困難な、角度制限ができることが特徴
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
}