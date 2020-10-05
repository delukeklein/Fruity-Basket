// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace FruityBasket.Input
{
    public class @ControlsAssetRefrence : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @ControlsAssetRefrence()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""8af74956-f60f-4483-97e9-97e93632afb1"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""6256a288-2fbd-47c7-8450-85a462df0ca1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""PC"",
                    ""id"": ""d0fb9af4-1511-4b4d-b4d5-7755695967c5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d14ba65a-2d2c-4095-a4ca-ae612e4e4e20"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c83eacec-2c6d-445e-81ea-99cd87feaa14"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad D-Pad"",
                    ""id"": ""89ddfa19-9ba4-43d7-9a36-33d33c35b4fc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d130f055-0d09-4fad-891c-119326a849f1"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9a73ba3d-9c2b-44f4-89cd-e1d943bf33fd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""cfc66a0b-376a-4437-a884-58c6e7f35518"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6d32f4d4-daa0-42cd-b428-56a83c623c58"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ee0eca42-7d8d-4a66-9766-5398a124fd5b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""aa27c18b-9f01-4509-8d45-6e03c3efa2bb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d84d47d2-c113-4359-8d4c-7465bc5704c2"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""019b5bba-8434-4012-9c1f-9821fc8b7dd2"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Swipe"",
                    ""id"": ""bc0992d9-a2a2-4834-add3-bb161ac04b50"",
                    ""path"": ""Swipe(MinimalSwipeDistance=0.15)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""StartPosition"",
                    ""id"": ""cee32977-dbc8-4468-b290-87c14bd9e319"",
                    ""path"": ""<Touchscreen>/primaryTouch/startPosition/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Position"",
                    ""id"": ""46e7263f-ee72-4aea-8061-2e752ed60c2d"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Movement
            m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
            m_Movement_Horizontal = m_Movement.FindAction("Horizontal", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Movement
        private readonly InputActionMap m_Movement;
        private IMovementActions m_MovementActionsCallbackInterface;
        private readonly InputAction m_Movement_Horizontal;
        public struct MovementActions
        {
            private @ControlsAssetRefrence m_Wrapper;
            public MovementActions(@ControlsAssetRefrence wrapper) { m_Wrapper = wrapper; }
            public InputAction @Horizontal => m_Wrapper.m_Movement_Horizontal;
            public InputActionMap Get() { return m_Wrapper.m_Movement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
            public void SetCallbacks(IMovementActions instance)
            {
                if (m_Wrapper.m_MovementActionsCallbackInterface != null)
                {
                    @Horizontal.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                    @Horizontal.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                    @Horizontal.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                }
                m_Wrapper.m_MovementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Horizontal.started += instance.OnHorizontal;
                    @Horizontal.performed += instance.OnHorizontal;
                    @Horizontal.canceled += instance.OnHorizontal;
                }
            }
        }
        public MovementActions @Movement => new MovementActions(this);
        public interface IMovementActions
        {
            void OnHorizontal(InputAction.CallbackContext context);
        }
    }
}
