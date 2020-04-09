using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Neoria.InGame.Domain.Player
{
    public class MoveVector2
    {
        const float min = -1000f;
        const float max = 1000f;

        public readonly Vector2 value;

        public MoveVector2(Vector2 value)
        {
            if (value.x < min) throw new ArgumentOutOfRangeException();
            if (value.x > max) throw new ArgumentOutOfRangeException();
            if (value.y < min) throw new ArgumentOutOfRangeException();
            if (value.y > max) throw new ArgumentOutOfRangeException();
            this.value = value;
        }

        public MoveVector2 Multi(MoveSpeed speed)
        {
            var result = this.value * speed.value;
            return new MoveVector2(result);
        }

        public MoveVector2 MultiCurrentFrameTime()
        {
            var result = this.value * Time.deltaTime;
            return new MoveVector2(result);
        }

        public MoveVector2 SolveThatSlantIsRoot2()
        {
            Vector2 normalized = this.value.normalized;
            float decreaseRateX = Mathf.Abs(normalized.x);
            float decreaseRateY = Mathf.Abs(normalized.y);
            float x = this.value.x * decreaseRateX;
            float y = this.value.y * decreaseRateY;
            return new MoveVector2(new Vector2(x, y));
        }

        /// 移動ベクトルをカメラの水平な正面の向きに回転させる
        public MoveVector2 RotateTo(Vector3 cameraForward)
        {
            Vector3 horizontalMoveVector3 = new Vector3(this.value.x, 0, this.value.y);
            Vector3 horizontalCameraForward = new Vector3(cameraForward.x, 0, cameraForward.z);
            var result = Quaternion.LookRotation(horizontalCameraForward, Vector3.up) * horizontalMoveVector3;
            return new MoveVector2(new Vector2(result.x, result.z));
        }

        public Vector3 ToXZOfVector3()
        {
            return new Vector3(value.x, 0, value.y);
        }
    }
}