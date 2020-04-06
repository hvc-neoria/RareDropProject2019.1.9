// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// namespace InGame.Presentation
// {
//     public class Test : MonoBehaviour
//     {
//         CharacterController charaControllerCache;
//         Transform cameraTransformCache;

//         void Awake()
//         {
//             charaControllerCache = GetComponent<CharacterController>();;
//             cameraTransformCache = Camera.main.transform;
//         }

//         void Update()
//         {
//             // pre
//             var h = Input.GetAxis("Horizontal");
//             var v = Input.GetAxis("Vertical");
//             // preをdomain用へ変換
//             var moveVector2 = new MoveVector2(new Vector2(h, v));

//             // ユースケース
//             MoveSpeed speed = new MoveSpeed(3f);
//             moveVector2 = moveVector2.MultiDeltaTime().Multi(speed);

//             // pre用変換
//             var vector3ByCharaCon = new Vector3(moveVector2.value.x, 0, moveVector2.value.y);

//             vector3ByCharaCon = Quaternion.LookRotation(cameraTransformCache.forward, Vector3.up) * vector3ByCharaCon;
//             // pre
//             charaControllerCache.Move(vector3ByCharaCon);
//             // var moveInput = new MoveInput(h, v);
//             // var vector3 = new Vector3(h, 0, v);
//             // var hoge = new MoveVector(vector3);
//             // MoveSpeed speed = new MoveSpeed(3f);
//             // hoge = hoge.Multi(speed).MoveVectorPerFrame();
//             // // pre
//             // charaControllerCache.position += hoge.value;
//             // // charaControllerCache.forward
//         }
//     }
// }