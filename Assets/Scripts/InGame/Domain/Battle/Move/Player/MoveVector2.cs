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

        readonly Vector2 value;

        public MoveVector2(Vector2 value)
        {
            if (value.x < min) throw new ArgumentOutOfRangeException();
            if (value.x > max) throw new ArgumentOutOfRangeException();
            if (value.y < min) throw new ArgumentOutOfRangeException();
            if (value.y > max) throw new ArgumentOutOfRangeException();
            this.value = value;
        }

        // 入力を移動ベクトルへ
        public Vector3 Move(MoveSpeed speed, Vector3 cameraForward)
        {
            var result = new MoveVector2(this.value)
                .Multi(speed)
                .MultiDeltaTime()
                .Turn(cameraForward)
                .ToXZOfVector3();
            return result;
        }

        MoveVector2 Multi(MoveSpeed speed)
        {
            var result = this.value * speed.value;
            return new MoveVector2(result);
        }

        // todo rename かける1可変フレームの時間 MultiDynamicFrameTime?
        MoveVector2 MultiDeltaTime()
        {
            var result = this.value * Time.deltaTime;
            return new MoveVector2(result);
        }

        // 斜めを丸くする
        // MoveVector2 Round()
        // {
        //     if(this.value == Vector2.zero) return new MoveVector2(Vector2.zero);
        //     Vector2 direction = this.value.normalized;
        //     // Mathf.Cos(1f)
        //     // float magnitude = 
        // }

        // カメラの向きに回転する
        MoveVector2 Turn(Vector3 cameraForward)
        {
            Vector3 vector3ByTurning = new Vector3(this.value.x, 0, this.value.y);
            // 移動ベクトルの正面を、カメラの正面向きベクトルに回転する
            var result = Quaternion.LookRotation(cameraForward, Vector3.up) * vector3ByTurning;
            return new MoveVector2(new Vector2(result.x, result.z));
        }

        Vector3 ToXZOfVector3()
        {
            return new Vector3(value.x, 0, value.y);
        }
    }
}