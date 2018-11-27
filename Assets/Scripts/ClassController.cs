using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassController : MonoBehaviour {

    private PlayerAttributes playerAttributes;
    private UIController uIController;

    // Use this for initialization
    void Start () {
        playerAttributes = GetComponent<PlayerAttributes>();
        uIController = GetComponent<UIController>();
    }
	
    public void ChooseTank()
    {
        playerAttributes.ForwardSpeed = 6.0f;
        playerAttributes.Health = 120.0f;
        uIController.changeUI(UIController.GameUI.WAITING);
    }

    public void ChooseKnight()
    {
        playerAttributes.Damage = 25.0f;
        uIController.changeUI(UIController.GameUI.WAITING);
    }

    public void ChooseSonic()
    {
        playerAttributes.ForwardSpeed = 10.0f;
        playerAttributes.RunMultiplier = 2.5f;
        uIController.changeUI(UIController.GameUI.WAITING);
    }
}
