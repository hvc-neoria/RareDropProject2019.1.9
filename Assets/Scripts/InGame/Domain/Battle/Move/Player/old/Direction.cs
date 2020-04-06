using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Direction
    {
        const float min = -1f;
        const float max = 1f;

        public readonly Vector3 value;

        public Direction(Vector3 value){
            if (value.x < min) throw new ArgumentOutOfRangeException();
            if (value.x > max) throw new ArgumentOutOfRangeException();
            if (value.y < min) throw new ArgumentOutOfRangeException();
            if (value.y > max) throw new ArgumentOutOfRangeException();
            if (value.z < min) throw new ArgumentOutOfRangeException();
            if (value.z > max) throw new ArgumentOutOfRangeException();
            this.value = value;
        }

        // public Direction Hoge()
        // {
            
        // }

    }