using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPresenter : MonoBehaviour
{
    void Update()
    {
        PlayerInput input = new PlayerInput();
        if(input.Attack())
        {
            Debug.Log("W");
            // playerを攻撃モーションさせる
            // 武器の攻撃判定を有効化する
        }
    }
}