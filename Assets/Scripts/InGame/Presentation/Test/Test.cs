using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        try { new HP(-1); throw new ArgumentException(); } catch(ArgumentOutOfRangeException) { }
        new HP(0);
        new HP(50);
        new HP(50);
        new HP(999);
        try { new HP(1); throw new ArgumentException(); } catch { }
        // Debug.Log("ALL OK");
    }
}
