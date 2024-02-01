//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerTwoInput.inputactions
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

public partial class @PlayerTwoInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerTwoInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerTwoInput"",
    ""maps"": [
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""62d29c9b-b4c5-487c-a902-80ac3640c7ac"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""da16409e-e28d-4dc7-b29f-6a77c3ef391c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""56e0ad18-ba80-4ec7-86c2-1203ebc01009"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""86d3931d-3c33-453d-8c0d-d69c2108411b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a5d5eb54-7210-4585-8918-410d144e166e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""db2e43fe-4e40-498f-a4fa-2488575aaa20"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a0129b32-eb6c-4acf-98df-eb6c3314b20f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_Move = m_PlayerTwo.FindAction("Move", throwIfNotFound: true);
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

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private List<IPlayerTwoActions> m_PlayerTwoActionsCallbackInterfaces = new List<IPlayerTwoActions>();
    private readonly InputAction m_PlayerTwo_Move;
    public struct PlayerTwoActions
    {
        private @PlayerTwoInput m_Wrapper;
        public PlayerTwoActions(@PlayerTwoInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerTwo_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerTwoActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerTwoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerTwoActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayerTwoActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerTwoActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerTwoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerTwoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);
    public interface IPlayerTwoActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
