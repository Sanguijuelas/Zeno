using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    public Canvas hudCanvas;
    public Canvas classCanvas;
    public Canvas waitingCanvas;
    public Canvas respawnCanvas;
    public GameObject model;

    public enum GameUI
    {
        GAME,
        CLASS,
        WAITING,
        RESPAWN,
        END
    }
    
    private static int playersReady = 0;
    private static List<UIController> uiControllers = new List<UIController>();
    private GameUI selected = GameUI.CLASS;

    public void Start()
    {
        uiControllers.Add(this);
    }

    public void changeUI(GameUI gameUI) {
        if (gameUI == selected)
        {
            return;
        }

        if (gameUI == GameUI.WAITING)
        {
            if (playersReady >= 3)
            {
                playersReady = 0;
                foreach (UIController controller in uiControllers)
                {

                    controller.changeUI(GameUI.GAME);
                }

                return;
            } else
            {
                playersReady++;
            }
        }

        switch (gameUI)
        {
            case GameUI.GAME:
                model.SetActive(true);
                hudCanvas.gameObject.SetActive(true);
                classCanvas.gameObject.SetActive(false);
                respawnCanvas.gameObject.SetActive(false);
                waitingCanvas.gameObject.SetActive(false);
                break;
            case GameUI.CLASS:
                hudCanvas.gameObject.SetActive(false);
                classCanvas.gameObject.SetActive(true);
                respawnCanvas.gameObject.SetActive(false);
                waitingCanvas.gameObject.SetActive(false);
                break;
            case GameUI.WAITING:
                hudCanvas.gameObject.SetActive(false);
                classCanvas.gameObject.SetActive(false);
                respawnCanvas.gameObject.SetActive(false);
                waitingCanvas.gameObject.SetActive(true);
                break;
            case GameUI.RESPAWN:
                model.SetActive(false);
                hudCanvas.gameObject.SetActive(false);
                classCanvas.gameObject.SetActive(false);
                respawnCanvas.gameObject.SetActive(true);
                waitingCanvas.gameObject.SetActive(false);
                break;
            case GameUI.END:
                hudCanvas.gameObject.SetActive(false);
                classCanvas.gameObject.SetActive(false);
                respawnCanvas.gameObject.SetActive(false);
                waitingCanvas.gameObject.SetActive(false);
                break;
        }

        selected = gameUI;
    }

    public GameUI getCurrentUI()
    {
        return selected;
    }
}
