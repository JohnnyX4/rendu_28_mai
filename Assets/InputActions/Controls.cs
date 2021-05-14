// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""773a044a-cfff-4003-b72d-65577f955168"",
            ""actions"": [
                {
                    ""name"": ""Grav"",
                    ""type"": ""Button"",
                    ""id"": ""b347e0e3-0891-4642-9ebd-997c1e3c5135"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7222cdba-de8e-44a1-8598-4e3f6b14781a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ghost"",
                    ""type"": ""Button"",
                    ""id"": ""a8a0dcf0-dd0c-4c45-9712-d99f73a60af2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3bb811e5-24f0-4051-b807-31bf20a8f6e7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""91659d71-a519-4bdb-9f39-422afe686031"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5d48fa63-765d-405e-855a-dd5f3c613dc4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""829f1b8d-144d-4601-b238-ea8f4af5cdba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""06e8b3fa-e4ff-4f4a-9c95-0c2bc5062847"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ghost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Grav = m_Main.FindAction("Grav", throwIfNotFound: true);
        m_Main_Move = m_Main.FindAction("Move", throwIfNotFound: true);
        m_Main_Ghost = m_Main.FindAction("Ghost", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Grav;
    private readonly InputAction m_Main_Move;
    private readonly InputAction m_Main_Ghost;
    public struct MainActions
    {
        private @Controls m_Wrapper;
        public MainActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grav => m_Wrapper.m_Main_Grav;
        public InputAction @Move => m_Wrapper.m_Main_Move;
        public InputAction @Ghost => m_Wrapper.m_Main_Ghost;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Grav.started -= m_Wrapper.m_MainActionsCallbackInterface.OnGrav;
                @Grav.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnGrav;
                @Grav.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnGrav;
                @Move.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Ghost.started -= m_Wrapper.m_MainActionsCallbackInterface.OnGhost;
                @Ghost.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnGhost;
                @Ghost.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnGhost;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grav.started += instance.OnGrav;
                @Grav.performed += instance.OnGrav;
                @Grav.canceled += instance.OnGrav;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Ghost.started += instance.OnGhost;
                @Ghost.performed += instance.OnGhost;
                @Ghost.canceled += instance.OnGhost;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnGrav(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnGhost(InputAction.CallbackContext context);
    }
}
