using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {

    public Camera fpsCam;
    
    public float range = 100f;
    private PlayerAttributes playerAttributes;

    private void Start() {
        playerAttributes = GetComponent<PlayerAttributes>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }

	}

    void Shoot() {
        if (playerAttributes.IsPaused()) {
            return;
        }

        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {

            PlayerHealth target = hit.transform.GetComponent<PlayerHealth>();

            if (target != null) {
                target.takeDamage(playerAttributes.Damage, playerAttributes);
            }
        }
    }
}