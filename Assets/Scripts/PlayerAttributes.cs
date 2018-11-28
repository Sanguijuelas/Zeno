using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour {

    public float Health = 100.0f;       // How much health does the player have
    public float Damage = 10.0f;        // How much damage shooting does
    public float ForwardSpeed = 8.0f;   // Speed when walking forward
    public float BackwardSpeed = 4.0f;  // Speed when walking backwards
    public float StrafeSpeed = 4.0f;    // Speed when walking sideways
    public float RunMultiplier = 2.0f;  // Speed when sprinting
    public float JumpForce = 30f;       // Jumping force
    public float range = 100f;          // shoot range
    public int kills;                   // kills
    public int deaths;                  // deaths
    public float initialX;
    public float initialZ;
    public GameObject player;
    public Vector3 initial;

    private UIController uIController;

    public void Start() {
        uIController = GetComponent<UIController>();
        player = gameObject;
        initialX = player.transform.position.x;
        initialZ = player.transform.position.z;
        initial = new Vector3(initialX, 1, initialZ);
        kills = 0;
        deaths = 0;
    }

    public bool IsPaused() {
        return uIController.getCurrentUI() != UIController.GameUI.GAME;
    }
}
