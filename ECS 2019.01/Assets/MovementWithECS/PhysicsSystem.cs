using Unity.Entities;
using Unity.Mathematics;

public class PhysicsSystem : ComponentSystem
{
    private EntityQuery group;
    protected override void OnCreateManager()
    {
        group = GetEntityQuery(
            typeof(RigidBody),
            typeof(Position));
    }
    protected override void OnUpdate()
    {
        float dt = UnityEngine.Time.deltaTime;

        var positon = group.GetComponentDataArray
    }
}
