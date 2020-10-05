using Unity.Entities;
using Unity.Physics.Systems;

[UpdateBefore(typeof(EndFramePhysicsSystem))]
[UpdateAfter(typeof(StepPhysicsWorld))]
public abstract class CollisionSystemBase : SystemBase
{
    protected BuildPhysicsWorld BuildPhysicsWorld { get; private set; }

    protected StepPhysicsWorld StepPhysicsWorld { get; private set; }

    protected override void OnCreate()
    {
        BuildPhysicsWorld = World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<BuildPhysicsWorld>();
        StepPhysicsWorld = World.DefaultGameObjectInjectionWorld.GetOrCreateSystem<StepPhysicsWorld>();
    }
}