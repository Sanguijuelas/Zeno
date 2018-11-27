using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour {

    public float Health = 100.0f;       // How much health does the player have
    public float Damage = 20.0f;        // How much damage shooting does
    public float ForwardSpeed = 8.0f;   // Speed when walking forward
    public float BackwardSpeed = 4.0f;  // Speed when walking backwards
    public float StrafeSpeed = 4.0f;    // Speed when walking sideways
    public float RunMultiplier = 2.0f;  // Speed when sprinting
    public float JumpForce = 30f;       // Jumping force
    public float range = 100f;          // shoot range

    private UIController uIController;

    public void Start() {
        uIController = GetComponent<UIController>();
    }

    public bool IsPaused() {
        return uIController.getCurrentUI() != UIController.GameUI.GAME;
    }
}
