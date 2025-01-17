//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""270d21ea-1a0d-4ec9-a3ee-83c963319d97"",
            ""actions"": [
                {
                    ""name"": ""RotateToLeft"",
                    ""type"": ""Button"",
                    ""id"": ""ea3b7e9a-1331-4adb-abf2-a6f876fb54ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateToRight"",
                    ""type"": ""Button"",
                    ""id"": ""19fc7f8a-a433-4b74-98f9-84317f0213b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpeedUp"",
                    ""type"": ""Button"",
                    ""id"": ""e9a732a5-9d4b-4008-aab7-ce08ae4ec494"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ffad20f-c391-45bd-b474-e8a2f3f6f9ae"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateToLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97aecca0-70b8-4c69-b3d1-d955473a9858"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateToRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7064978c-3418-4d14-a37a-d4704565ab85"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_RotateToLeft = m_Player.FindAction("RotateToLeft", throwIfNotFound: true);
        m_Player_RotateToRight = m_Player.FindAction("RotateToRight", throwIfNotFound: true);
        m_Player_SpeedUp = m_Player.FindAction("SpeedUp", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_RotateToLeft;
    private readonly InputAction m_Player_RotateToRight;
    private readonly InputAction m_Player_SpeedUp;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateToLeft => m_Wrapper.m_Player_RotateToLeft;
        public InputAction @RotateToRight => m_Wrapper.m_Player_RotateToRight;
        public InputAction @SpeedUp => m_Wrapper.m_Player_SpeedUp;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @RotateToLeft.started += instance.OnRotateToLeft;
            @RotateToLeft.performed += instance.OnRotateToLeft;
            @RotateToLeft.canceled += instance.OnRotateToLeft;
            @RotateToRight.started += instance.OnRotateToRight;
            @RotateToRight.performed += instance.OnRotateToRight;
            @RotateToRight.canceled += instance.OnRotateToRight;
            @SpeedUp.started += instance.OnSpeedUp;
            @SpeedUp.performed += instance.OnSpeedUp;
            @SpeedUp.canceled += instance.OnSpeedUp;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @RotateToLeft.started -= instance.OnRotateToLeft;
            @RotateToLeft.performed -= instance.OnRotateToLeft;
            @RotateToLeft.canceled -= instance.OnRotateToLeft;
            @RotateToRight.started -= instance.OnRotateToRight;
            @RotateToRight.performed -= instance.OnRotateToRight;
            @RotateToRight.canceled -= instance.OnRotateToRight;
            @SpeedUp.started -= instance.OnSpeedUp;
            @SpeedUp.performed -= instance.OnSpeedUp;
            @SpeedUp.canceled -= instance.OnSpeedUp;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnRotateToLeft(InputAction.CallbackContext context);
        void OnRotateToRight(InputAction.CallbackContext context);
        void OnSpeedUp(InputAction.CallbackContext context);
    }
}
