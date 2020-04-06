// using UnityEngine;
// interface IMover
// {
//     MoveVectorPerFrame MoveVectorPerFrame();
// }

// public class MoverType
// {

//     // MoveVectorPerFrame 
// }

// public class InputMover : IMover
// {
//     public readonly float horizontalInput;
//     public readonly float verticalInput;

//     public InputMover(float horizontalInput, float verticalInput)
//     {
//         this.horizontalInput = horizontalInput;
//         this.verticalInput = verticalInput;
//     }

//     public MoveVectorPerFrame MoveVectorPerFrame()
//     {
//         return new MoveVectorPerFrame(new Vector2(horizontalInput, verticalInput) * Time.deltaTime);
//     }

// }