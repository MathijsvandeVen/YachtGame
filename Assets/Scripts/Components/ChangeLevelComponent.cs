using UnityEngine;
using UnityEngine.UI;

public class ChangeLevelComponent : MonoBehaviour {

    // Adding scenes to the File >> Build Setting
    // The scenes get an index number

    // LevelNumber is the index number of the scene that should load after the button is clicked
    public int LevelNumber;
    // Button that will go to the scene with index number LevelNumber
    public Button button;

    void Start()
    {
        button = button.GetComponent<Button>();
    }
}


