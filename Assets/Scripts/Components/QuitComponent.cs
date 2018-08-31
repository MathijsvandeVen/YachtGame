using UnityEngine;
using UnityEngine.UI;

public class QuitComponent : MonoBehaviour {

    // Button that will close the game after it is clicked
    public Button quitButton;

    void Start()
    {
        quitButton = quitButton.GetComponent<Button>();
    }
}
