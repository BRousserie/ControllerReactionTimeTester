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
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""878c9c7b-71b1-42f2-bb72-ad00e94597cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""f6334d82-cbdc-40d2-bb42-96afa03d1538"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""64ef5fd7-2103-45e6-9fe0-e00b71eb7210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""a37487f0-bad6-4fba-8acf-c0c6a4b46082"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e634faf-343d-4fbd-a55e-ffbd46d90c11"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d31f873-6872-4fc2-ad4c-379482b93584"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS Controller"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56fe77bb-9aad-46a6-a976-8eb7335c9899"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""A"",
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
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e98ebf9-813e-4535-8210-38ab73e82f2c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3df81166-060d-414a-81f9-fc5ee7ead120"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47b99acd-5f52-4c63-b9f8-eee689fc4189"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""X"",
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
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81f52a72-a59d-44ea-af71-031ce71b0e0d"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""X"",
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
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7acc4240-d15d-4d35-8e00-4b3b1c2d5c9f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3763115a-1686-4c91-95cd-ee92a1780904"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxController"",
                    ""action"": ""Y"",
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
        }
    ]
}");
        // Buttons
        m_Buttons = asset.FindActionMap("Buttons", throwIfNotFound: true);
        m_Buttons_A = m_Buttons.FindAction("A", throwIfNotFound: true);
        m_Buttons_B = m_Buttons.FindAction("B", throwIfNotFound: true);
        m_Buttons_X = m_Buttons.FindAction("X", throwIfNotFound: true);
        m_Buttons_Y = m_Buttons.FindAction("Y", throwIfNotFound: true);
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
    private readonly InputAction m_Buttons_A;
    private readonly InputAction m_Buttons_B;
    private readonly InputAction m_Buttons_X;
    private readonly InputAction m_Buttons_Y;
    public struct ButtonsActions
    {
        private @InputMaster m_Wrapper;
        public ButtonsActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Buttons_A;
        public InputAction @B => m_Wrapper.m_Buttons_B;
        public InputAction @X => m_Wrapper.m_Buttons_X;
        public InputAction @Y => m_Wrapper.m_Buttons_Y;
        public InputActionMap Get() { return m_Wrapper.m_Buttons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ButtonsActions set) { return set.Get(); }
        public void SetCallbacks(IButtonsActions instance)
        {
            if (m_Wrapper.m_ButtonsActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_ButtonsActionsCallbackInterface.OnY;
            }
            m_Wrapper.m_ButtonsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
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
    public interface IButtonsActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
    }
}
