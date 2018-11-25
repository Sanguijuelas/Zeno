using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour {

    public float Health = 100.0f;
    public float Damage = 20.0f;
    public float ForwardSpeed = 8.0f;   // Speed when walking forward
    public float BackwardSpeed = 4.0f;  // Speed when walking backwards
    public float StrafeSpeed = 4.0f;    // Speed when walking sideways
    public float RunMultiplier = 2.0f;   // Speed when sprinting
    public float JumpForce = 30f;

}
