using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;
using UnityEngine.UI;

public class PanelSystem : ComponentSystem
{

    // Find the game objects with the ChangeCanvasComponent
    private struct Data
    {
        public ChangeCanvasComponent ChangeCanvas;
    }

    
    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
        {
            // When the button is clicked, a task is made to change the canvasses
            entity.ChangeCanvas.button.onClick.AddListener(TaskChangeCanvas);

            // Method to change the canvasses
            void TaskChangeCanvas()
            {
                // The Canvas that should be enabled will be set to Active
                entity.ChangeCanvas.CanvasEnable.SetActive(true);
                // The Canvas that should be disabled will be set to InActive
                entity.ChangeCanvas.CanvasDisable.SetActive(false);

            }  
        }
    }
}
