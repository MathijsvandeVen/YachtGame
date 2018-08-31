using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;
using UnityEngine.UI;

public class ScenesSystem : ComponentSystem
{
    // Adding scenes to the File >> Build Setting
    // The scenes get an index number

    // Find the game objects with the ChangeLevelComponent
    private struct Data
    {
        public ChangeLevelComponent ChangeLevel;
    }


    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
        {
            // After the button is clicked, a task will be made to change the scenes
            entity.ChangeLevel.button.onClick.AddListener(TaskChangeLevels);

            void TaskChangeLevels()
            {
                // This changes the scene to the scene with index LevelNumber
                SceneManager.LoadScene(entity.ChangeLevel.LevelNumber);
            }
        }

    }

    //    public void NextLevel()
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //    }

    //    public void HomePage()
    //    {
    //        SceneManager.LoadScene(0);
    //    }

    //    public void QuitGame()
    //    {
    //        Debug.Log("QUIT");
    //        Application.Quit();
    //    }

    //    //public void LevelOne()
    //    //{
    //    //    SceneManager.LoadScene(1);
    //    //}

    //    //public void LevelTwo()
    //    //{
    //    //    SceneManager.LoadScene(2);
    //    //}

    //    //public void LevelThree()
    //    //{
    //    //    SceneManager.LoadScene(3);
    //    //}

    //    public void ChangeLevel(int LevelNumber)
    //    {
    //        SceneManager.LoadScene(LevelNumber);
    //    }
}
