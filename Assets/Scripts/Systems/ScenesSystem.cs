using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSystem : MonoBehaviour {

    // Adding scenes to the File >> Build Setting
    // The scenes get an index number

    // Add to a button the script ScenesSystem.cs
    // Add to Button (Script) >> On Click () >> Plus (Add to List) >>  Add the player object (button) >> Add to Function add the method from the SceneSystem (replace no function with the method)

    // Method to go to the next level
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Method to go to the homepage (index = 0)
    public void HomePage()
    {
        SceneManager.LoadScene(0);
    }

    // Method to quit te game
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    //// Not necessary anymore
    //// Method to go to level 1, 2 or 3
    //public void LevelOne()
    //{
    //    SceneManager.LoadScene(1);
    //}

    //public void LevelTwo()
    //{
    //    SceneManager.LoadScene(2);
    //}

    //public void LevelThree()
    //{
    //    SceneManager.LoadScene(3);
    //}

    // Method to change to another level based on an integer
    public void ChangeLevel(int LevelNumber)
    {
        SceneManager.LoadScene(LevelNumber);
    }
}
