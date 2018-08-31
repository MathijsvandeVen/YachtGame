using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;

public class QuitSystem : ComponentSystem
{

    // Find the game objects with the QuitComponent
    private struct Data
    {
        public QuitComponent QuitGame;
    }


    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
        {
            // After the button is clicked, a task will be made to change close the game
            entity.QuitGame.quitButton.onClick.AddListener(TaskQuitGame);
            
            void TaskQuitGame()
            {
                // For Debugging QUIT will be written to console
                Debug.Log("QUIT");
                // To close the game
                Application.Quit();
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
