//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Inputs/PlayerInputs.inputactions
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

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""CameraMovement"",
            ""id"": ""e56cb1d9-21d4-4680-a317-36e1e758aa43"",
            ""actions"": [
                {
                    ""name"": ""Drag"",
                    ""type"": ""Button"",
                    ""id"": ""20a0e43e-db39-4c08-a435-4dbd1403ff00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""f33d0572-05be-4c9e-9d06-5d8b3e8f2336"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""2b0079de-9e04-4c67-b68d-8116eda76b48"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PrimaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""6c604764-9d37-4f6b-835c-90d9caf3c58c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""f548499b-38b0-4c18-a4fe-bc1a4bdd1aa0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""45054228-9633-47c2-b078-c529a2abc2e4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0e01640-b284-4327-a0ed-3d465170d93f"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcdb8be4-5fb8-42c8-95ae-7f1c4783f647"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5be093a-6ae3-4281-b3d4-bcf99fc28c05"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e8f7663-5195-44b0-b3de-3837d2e068c7"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraMovement
        m_CameraMovement = asset.FindActionMap("CameraMovement", throwIfNotFound: true);
        m_CameraMovement_Drag = m_CameraMovement.FindAction("Drag", throwIfNotFound: true);
        m_CameraMovement_PrimaryFingerPosition = m_CameraMovement.FindAction("PrimaryFingerPosition", throwIfNotFound: true);
        m_CameraMovement_SecondaryFingerPosition = m_CameraMovement.FindAction("SecondaryFingerPosition", throwIfNotFound: true);
        m_CameraMovement_PrimaryTouchContact = m_CameraMovement.FindAction("PrimaryTouchContact", throwIfNotFound: true);
        m_CameraMovement_SecondaryTouchContact = m_CameraMovement.FindAction("SecondaryTouchContact", throwIfNotFound: true);
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

    // CameraMovement
    private readonly InputActionMap m_CameraMovement;
    private List<ICameraMovementActions> m_CameraMovementActionsCallbackInterfaces = new List<ICameraMovementActions>();
    private readonly InputAction m_CameraMovement_Drag;
    private readonly InputAction m_CameraMovement_PrimaryFingerPosition;
    private readonly InputAction m_CameraMovement_SecondaryFingerPosition;
    private readonly InputAction m_CameraMovement_PrimaryTouchContact;
    private readonly InputAction m_CameraMovement_SecondaryTouchContact;
    public struct CameraMovementActions
    {
        private @PlayerInputs m_Wrapper;
        public CameraMovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drag => m_Wrapper.m_CameraMovement_Drag;
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_CameraMovement_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_CameraMovement_SecondaryFingerPosition;
        public InputAction @PrimaryTouchContact => m_Wrapper.m_CameraMovement_PrimaryTouchContact;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_CameraMovement_SecondaryTouchContact;
        public InputActionMap Get() { return m_Wrapper.m_CameraMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMovementActions set) { return set.Get(); }
        public void AddCallbacks(ICameraMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraMovementActionsCallbackInterfaces.Add(instance);
            @Drag.started += instance.OnDrag;
            @Drag.performed += instance.OnDrag;
            @Drag.canceled += instance.OnDrag;
            @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
            @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
            @PrimaryTouchContact.started += instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.performed += instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.canceled += instance.OnPrimaryTouchContact;
            @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
        }

        private void UnregisterCallbacks(ICameraMovementActions instance)
        {
            @Drag.started -= instance.OnDrag;
            @Drag.performed -= instance.OnDrag;
            @Drag.canceled -= instance.OnDrag;
            @PrimaryFingerPosition.started -= instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.performed -= instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.canceled -= instance.OnPrimaryFingerPosition;
            @SecondaryFingerPosition.started -= instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.performed -= instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.canceled -= instance.OnSecondaryFingerPosition;
            @PrimaryTouchContact.started -= instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.performed -= instance.OnPrimaryTouchContact;
            @PrimaryTouchContact.canceled -= instance.OnPrimaryTouchContact;
            @SecondaryTouchContact.started -= instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.performed -= instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.canceled -= instance.OnSecondaryTouchContact;
        }

        public void RemoveCallbacks(ICameraMovementActions instance)
        {
            if (m_Wrapper.m_CameraMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraMovementActions @CameraMovement => new CameraMovementActions(this);
    public interface ICameraMovementActions
    {
        void OnDrag(InputAction.CallbackContext context);
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnPrimaryTouchContact(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
    }
}
