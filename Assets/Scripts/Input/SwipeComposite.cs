#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Editor;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;
using Unity.Mathematics;

[InitializeOnLoad]
#endif
[DisplayStringFormat("{startPosition+position}")]
public class SwipeComposite : InputBindingComposite<float>
{
    [InputControl(layout = "Value")]
    public int StartPosition;

    [InputControl(layout = "Value")]
    public int Position;

    public float MinimalSwipeDistance;

    public override float ReadValue(ref InputBindingCompositeContext context)
    {
        float startPosition = context.ReadValue<float>(StartPosition);
        float position = context.ReadValue<float>(Position);
        float distance = math.abs(startPosition - position);

        return distance > MinimalSwipeDistance ? 0 : math.sign(startPosition - position);
    }

    static SwipeComposite()
    {
        InputSystem.RegisterBindingComposite<SwipeComposite>();
    }

    [RuntimeInitializeOnLoadMethod]
    static void Init() { }
}

#if UNITY_EDITOR
public class SwipeCompositeParameterEditor : InputParameterEditor<SwipeComposite>
{
    public override void OnGUI()
    {
        target.MinimalSwipeDistance = EditorGUILayout.FloatField("Minimal Swipe Distance", target.MinimalSwipeDistance);
    }
}
#endif