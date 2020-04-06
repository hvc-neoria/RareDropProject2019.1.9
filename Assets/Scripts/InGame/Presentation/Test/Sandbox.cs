using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandbox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(new InputMover(1f, 1f).MoveVectorPerFrame().value.x);
        // Debug.Log(Mathf.Cos(2f));
    }

    void Update()
    {
        // DownKeyCheck();
        Transform hoge = transform;
        // RotateAroundTest(hoge);

        // transform =  hoge;
        // var mage = new PlayerInput().MainAxis();
        // Debug.Log(mage.x + "hoge" + mage.y);
        // Debug.Log(-721f % 360f);
    }

    Transform RotateAroundTest(Transform trans)
    {
        var hoge = trans;
        trans.RotateAround(Vector3.zero, Vector3.up + transform.right, 45f * Time.deltaTime);
        return trans;
    }



    void DownKeyCheck()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(code))
                {
                    //処理を書く
                    Debug.Log(code);
                    break;
                }
            }
        }
    }
}