using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvasComponent : MonoBehaviour {

    // A canvas holds other buttons for the menu
    // CanvasEnable is the canvas that will enabled after the button is clicked
    // CanvasDisable is the canvas that will be disabled after the button is clicked
    public GameObject CanvasEnable, CanvasDisable;
    // Button that will serve to change the two canvasses
    public Button button;

    void Start()
    {
        button = button.GetComponent<Button>();
    }
}


