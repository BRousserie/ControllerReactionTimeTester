// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Buttons"",
            ""id"": ""f6700bc4-7181-46be-88ee-0572741c2ac2"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""a37487f0-bad6-4fba-8acf-c0c6a4b46082"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""878c9c7b-71b1-42f2-bb72-ad00e94597cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""64ef5fd7-2103-45e6-9fe0-e00b71eb7210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""f6334d82-cbdc-40d2-bb42-96afa03d1538"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1d31f873-6872-4fc2-ad4c-379482b93584"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS Controller"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15fb7cf3-c086-41c8-be1f-eac94b01c53b"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS Controller"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3657b9ce-5a82-453b-8f0c-a267d061b2ca"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS Controller"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7acc4240-d15d-4d35-8e00-4b3b1c2d5c9f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ceb5171c-12e4-4099-a989-4ba957aa4b5d"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS Controller"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e634faf-343d-4fbd-a55e-ffbd46d90c11"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47b99acd-5f52-4c63-b9f8-eee689fc4189"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e98ebf9-813e-4535-8210-38ab73e82f2c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""XboxController"",
            ""bindingGroup"": ""XboxController"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""PS Controller"",
            ""bindingGroup"": ""PS Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Buttons
        m_Buttons = asset.FindActionMap("Buttons", throwIfNotFound: true);
        m_Buttons_Up = m_Buttons.FindAction("Up", throwIfNotFound: true);
        m_Buttons_Down = m_Buttons.FindAction("Down", throwIfNotFound: true);
        m_Buttons_Left = m_Buttons.FindAction("Left", throwIfNotFound: true);
        m_Buttons_Right = m_Buttons.FindAction("Right", throwIfNotFound: true);
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

    // Buttons
    private readonly InputActionMap m_Buttons;
    private IButtonsActions m_ButtonsActionsCallbackInterface;
    private readonly InputAction m_Buttons_Up;
    private readonly InputAction m_Buttons_Down;
    private readonly InputAction m_Buttons_Left;
    private readonly InputAction m_Buttons_Right;
    public struct ButtonsActions
    {
        private @InputMaster m_Wrapper;
        public ButtonsActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Buttons_Up;
        public InputAction @Down => m_Wrapper.m_Buttons_Down;
        public InputAction @Left => m_Wrapper.m_Buttons_Left;
        public InputAction @Right => m_Wrapper.m_Buttons_Right;
        public InputActionMap Get() { return m_Wrapper.m_Buttons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ButtonsActions set) { return set.Get(); }
        public void SetCallbacks(IButtonsActions instance)
        {
            if (m_Wrapper.m_ButtonsActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_ButtonsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public ButtonsActions @Buttons => new ButtonsActions(this);
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("XboxController");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    private int m_PSControllerSchemeIndex = -1;
    public InputControlScheme PSControllerScheme
    {
        get
        {
            if (m_PSControllerSchemeIndex == -1) m_PSControllerSchemeIndex = asset.FindControlSchemeIndex("PS Controller");
            return asset.controlSchemes[m_PSControllerSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IButtonsActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
