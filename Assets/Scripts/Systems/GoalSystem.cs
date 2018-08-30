using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;

public class GoalSystem : ComponentSystem
{
    private struct Data
    {
        public ComponentArray<PlayerInputComponent> input;
    }

    private struct Filter
    {
        public GoalComponent gc;
        public BoxCollider bc;
    }

    [Inject] private Data _data;
    protected override void OnUpdate()
    {
        var goalEntity = GetEntities<Filter>();

        if (goalEntity.Length > 0)
        {
            var distance = 
                math.distance(goalEntity[0].gc.transform.position.x, _data.input[0].transform.position.x);            

            if(distance < 1)
            {
                Object.Destroy(goalEntity[0].gc.gameObject);
            }
        }

    }

}
