using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame.Domain
{
    public class DirectionInput
    {
        const float min = -1f;
        const float max = 1f;

        public readonly Vector2 value;

        public DirectionInput(float x, float y)
        {
            if (x < min) throw new ArgumentOutOfRangeException();
            if (x > max) throw new ArgumentOutOfRangeException();
            if (y < min) throw new ArgumentOutOfRangeException();
            if (y > max) throw new ArgumentOutOfRangeException();
            this.value = new Vector2(x, y);
        }
    }
}