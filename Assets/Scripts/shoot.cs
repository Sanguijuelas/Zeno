using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public Camera fpsCam;

    public float damage = 10f;
    public float range = 100f;
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }

	}

    void Shoot() {

        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {

            PlayerHealth target = hit.transform.GetComponent<PlayerHealth>();
            PlayerInfo targetInfo= hit.transform.GetComponent<PlayerInfo>();

            if (target != null) {
                target.takeDamage(damage);
                if (target.isDead){
                    targetInfo.deaths++;
                }
            }
        }
    }
}