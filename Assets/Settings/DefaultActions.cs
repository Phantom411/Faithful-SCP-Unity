// GENERATED AUTOMATICALLY FROM 'Assets/Settings/DefaultActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DefaultActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""bb05350e-d038-4622-ab63-d359c07fbc7f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8eb988d3-0f64-4d20-a892-f3bfbcef5677"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""eb48c530-b410-4022-b1fd-e9ebc6cd1698"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Blink"",
                    ""type"": ""Button"",
                    ""id"": ""d79f775f-fcbf-4271-a604-6eac5c462383"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""cbdb562a-a2c1-4b7e-938d-e010320a94f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InteractYes"",
                    ""type"": ""Button"",
                    ""id"": ""e88bcb32-64f9-43d2-8444-62103ec62881"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InteractHold"",
                    ""type"": ""Button"",
                    ""id"": ""10a89798-5151-4f86-b646-cc47aacac10b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""InteractNo"",
                    ""type"": ""Button"",
                    ""id"": ""2c3d3ef8-037a-461f-af13-03feb227c298"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RunHold"",
                    ""type"": ""Button"",
                    ""id"": ""1e83261e-ab3b-4f3f-8001-072aff7e928e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""CrouchTrigger"",
                    ""type"": ""Button"",
                    ""id"": ""a8d7367c-b155-48c8-913f-ae6f5dc597e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Radio1"",
                    ""type"": ""Button"",
                    ""id"": ""dc94ade9-f3d5-4e5c-aabf-58beaaf4f38d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Radio2"",
                    ""type"": ""Button"",
                    ""id"": ""5c75436b-4bce-4025-a56e-da506d98d3cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Radio3"",
                    ""type"": ""Button"",
                    ""id"": ""56c5d0df-0b13-4661-92e7-4ec07036f845"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Radio4"",
                    ""type"": ""Button"",
                    ""id"": ""430b2c86-8e1e-476c-8859-9e32377d8848"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Radio5"",
                    ""type"": ""Button"",
                    ""id"": ""08375e61-4356-48ce-87cb-d79dbe0b1392"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RadioNext"",
                    ""type"": ""Button"",
                    ""id"": ""172dc72e-919e-46c8-be86-459b619b4d8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RadioBack"",
                    ""type"": ""Button"",
                    ""id"": ""caef411b-4ec5-4b45-bbab-29411fb0af3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""fbba3364-dd51-4bfb-8a50-7935aecabace"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""c43547c1-86a0-4f8b-93bc-03080514adb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Debug"",
                    ""type"": ""Button"",
                    ""id"": ""1d464f3c-3912-4792-aba0-8356d1495c4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugF1"",
                    ""type"": ""Button"",
                    ""id"": ""34bc8862-dde0-4dcf-bc0e-8b3ba8052453"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KeyboardMove"",
                    ""id"": ""1bca9d89-a484-48b3-bf68-7af20c63c7ed"",
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
                    ""id"": ""c03ba609-8ee3-49db-9aab-57eca71c7716"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""93bbc871-590a-41ff-a6d0-80312555b0c9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8e7f3ccc-0ef2-44da-9335-40ba2432f936"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cbee0c91-f3e8-4b54-9fd7-b4af31bfce2d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1988baec-92ba-46d2-b7b7-9e0e978d0044"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ef56606-735a-4d69-9c6e-fbabf082ada4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.1,y=0.1)"",
                    ""groups"": ""Default"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bea888dc-f440-435f-bc23-a8ce2c37b12f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb7ffd07-c7f4-45d8-8272-3f6b64114b6d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Blink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3eb2ce5b-a568-4cbe-8a3f-4d4fa33d9dee"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Blink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""722a3af8-621d-49db-b0ac-1311c05b059f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e2cbefc-841f-4523-8f83-0c68ffb112a2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a4a72d8-16ca-4e77-a694-941cc41ee029"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""InteractYes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f487d418-926c-4862-8fcc-86c768fbf0e6"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""InteractYes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d635614-3158-474d-94ad-3612178daef9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""InteractNo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aac5742-d5c5-455b-af2e-26c204925e5b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""InteractNo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a81cd539-82a3-4ecd-aa71-82c1fbbbc419"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""RunHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""071668f2-ed5f-4297-bfe6-131a5c5898b4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""RunHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""583e2048-60e5-4310-bc44-3f33f73728ee"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""CrouchTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2aa98b0-adfb-4700-8beb-bcf19d653b82"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""CrouchTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""688e16f1-2251-4e0f-803d-5cee73c308c0"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Radio1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52134295-44e4-439b-a001-7cba2d12d64f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Radio2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcc25e43-309d-4a81-8041-15609931b0d9"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Radio3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dae4ff7-0b79-4c88-a228-f09b00aff18e"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Radio4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82b3e185-fc0e-4e45-85e7-a37af805a650"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Radio5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0439704-ae29-4d53-a01a-e12be7519ab5"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RadioNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9934330f-d77d-4093-bb49-34409c9fa9e0"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RadioNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6dca9c2f-7a87-41b3-908e-08330aa34581"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RadioBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62792058-c597-464f-a7b7-32c67462b737"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RadioBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38bd1c07-9207-4e41-a14a-cf56e8c581fb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""InteractHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d0404d7-42c8-4050-9c3f-62a96f658a8d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""InteractHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""013e1974-bbdc-4a3d-82a5-85d4d15465ff"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78866d90-c9aa-4dc3-ab12-de3ec69906e2"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""677d4914-acfe-4553-b014-8839b1985927"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32c7491d-9ec8-4b48-b2c9-b99e53db1575"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""270558d4-d51f-47e6-a0c7-e036f4513380"",
                    ""path"": ""<Keyboard>/f10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Debug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""813b6610-ca87-495b-94d8-79a28ab8fcb4"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""DebugF1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""1f08a409-6fbe-41fe-b41e-b4bc5cf6d89c"",
            ""actions"": [
                {
                    ""name"": ""Pointer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44778a53-12c1-43e3-8f88-6b1f7352280c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d90b440a-e60b-431d-a4d2-9db4ed176009"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""922df942-ada5-4ded-9d21-f28c952d38c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ce0fa76-cde4-4f34-96dc-c51979c1b447"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Pointer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98c1c6b0-2f51-4c91-9832-f06e14333452"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Right Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b4d32fa-f206-4cf9-ba4f-2836ac92a5c7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Default"",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default"",
            ""bindingGroup"": ""Default"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_Blink = m_Gameplay.FindAction("Blink", throwIfNotFound: true);
        m_Gameplay_Inventory = m_Gameplay.FindAction("Inventory", throwIfNotFound: true);
        m_Gameplay_InteractYes = m_Gameplay.FindAction("InteractYes", throwIfNotFound: true);
        m_Gameplay_InteractHold = m_Gameplay.FindAction("InteractHold", throwIfNotFound: true);
        m_Gameplay_InteractNo = m_Gameplay.FindAction("InteractNo", throwIfNotFound: true);
        m_Gameplay_RunHold = m_Gameplay.FindAction("RunHold", throwIfNotFound: true);
        m_Gameplay_CrouchTrigger = m_Gameplay.FindAction("CrouchTrigger", throwIfNotFound: true);
        m_Gameplay_Radio1 = m_Gameplay.FindAction("Radio1", throwIfNotFound: true);
        m_Gameplay_Radio2 = m_Gameplay.FindAction("Radio2", throwIfNotFound: true);
        m_Gameplay_Radio3 = m_Gameplay.FindAction("Radio3", throwIfNotFound: true);
        m_Gameplay_Radio4 = m_Gameplay.FindAction("Radio4", throwIfNotFound: true);
        m_Gameplay_Radio5 = m_Gameplay.FindAction("Radio5", throwIfNotFound: true);
        m_Gameplay_RadioNext = m_Gameplay.FindAction("RadioNext", throwIfNotFound: true);
        m_Gameplay_RadioBack = m_Gameplay.FindAction("RadioBack", throwIfNotFound: true);
        m_Gameplay_Save = m_Gameplay.FindAction("Save", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Debug = m_Gameplay.FindAction("Debug", throwIfNotFound: true);
        m_Gameplay_DebugF1 = m_Gameplay.FindAction("DebugF1", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Pointer = m_UI.FindAction("Pointer", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("Right Click", throwIfNotFound: true);
        m_UI_LeftClick = m_UI.FindAction("Left Click", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_Blink;
    private readonly InputAction m_Gameplay_Inventory;
    private readonly InputAction m_Gameplay_InteractYes;
    private readonly InputAction m_Gameplay_InteractHold;
    private readonly InputAction m_Gameplay_InteractNo;
    private readonly InputAction m_Gameplay_RunHold;
    private readonly InputAction m_Gameplay_CrouchTrigger;
    private readonly InputAction m_Gameplay_Radio1;
    private readonly InputAction m_Gameplay_Radio2;
    private readonly InputAction m_Gameplay_Radio3;
    private readonly InputAction m_Gameplay_Radio4;
    private readonly InputAction m_Gameplay_Radio5;
    private readonly InputAction m_Gameplay_RadioNext;
    private readonly InputAction m_Gameplay_RadioBack;
    private readonly InputAction m_Gameplay_Save;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Debug;
    private readonly InputAction m_Gameplay_DebugF1;
    public struct GameplayActions
    {
        private @DefaultActions m_Wrapper;
        public GameplayActions(@DefaultActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @Blink => m_Wrapper.m_Gameplay_Blink;
        public InputAction @Inventory => m_Wrapper.m_Gameplay_Inventory;
        public InputAction @InteractYes => m_Wrapper.m_Gameplay_InteractYes;
        public InputAction @InteractHold => m_Wrapper.m_Gameplay_InteractHold;
        public InputAction @InteractNo => m_Wrapper.m_Gameplay_InteractNo;
        public InputAction @RunHold => m_Wrapper.m_Gameplay_RunHold;
        public InputAction @CrouchTrigger => m_Wrapper.m_Gameplay_CrouchTrigger;
        public InputAction @Radio1 => m_Wrapper.m_Gameplay_Radio1;
        public InputAction @Radio2 => m_Wrapper.m_Gameplay_Radio2;
        public InputAction @Radio3 => m_Wrapper.m_Gameplay_Radio3;
        public InputAction @Radio4 => m_Wrapper.m_Gameplay_Radio4;
        public InputAction @Radio5 => m_Wrapper.m_Gameplay_Radio5;
        public InputAction @RadioNext => m_Wrapper.m_Gameplay_RadioNext;
        public InputAction @RadioBack => m_Wrapper.m_Gameplay_RadioBack;
        public InputAction @Save => m_Wrapper.m_Gameplay_Save;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputAction @Debug => m_Wrapper.m_Gameplay_Debug;
        public InputAction @DebugF1 => m_Wrapper.m_Gameplay_DebugF1;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Blink.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBlink;
                @Blink.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBlink;
                @Blink.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBlink;
                @Inventory.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventory;
                @InteractYes.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractYes;
                @InteractYes.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractYes;
                @InteractYes.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractYes;
                @InteractHold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractHold;
                @InteractHold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractHold;
                @InteractHold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractHold;
                @InteractNo.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractNo;
                @InteractNo.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractNo;
                @InteractNo.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteractNo;
                @RunHold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunHold;
                @RunHold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunHold;
                @RunHold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunHold;
                @CrouchTrigger.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouchTrigger;
                @CrouchTrigger.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouchTrigger;
                @CrouchTrigger.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouchTrigger;
                @Radio1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio1;
                @Radio1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio1;
                @Radio1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio1;
                @Radio2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio2;
                @Radio2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio2;
                @Radio2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio2;
                @Radio3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio3;
                @Radio3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio3;
                @Radio3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio3;
                @Radio4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio4;
                @Radio4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio4;
                @Radio4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio4;
                @Radio5.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio5;
                @Radio5.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio5;
                @Radio5.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadio5;
                @RadioNext.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadioNext;
                @RadioNext.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadioNext;
                @RadioNext.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadioNext;
                @RadioBack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadioBack;
                @RadioBack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadioBack;
                @RadioBack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRadioBack;
                @Save.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSave;
                @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @Debug.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug;
                @Debug.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug;
                @Debug.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug;
                @DebugF1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebugF1;
                @DebugF1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebugF1;
                @DebugF1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebugF1;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Blink.started += instance.OnBlink;
                @Blink.performed += instance.OnBlink;
                @Blink.canceled += instance.OnBlink;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @InteractYes.started += instance.OnInteractYes;
                @InteractYes.performed += instance.OnInteractYes;
                @InteractYes.canceled += instance.OnInteractYes;
                @InteractHold.started += instance.OnInteractHold;
                @InteractHold.performed += instance.OnInteractHold;
                @InteractHold.canceled += instance.OnInteractHold;
                @InteractNo.started += instance.OnInteractNo;
                @InteractNo.performed += instance.OnInteractNo;
                @InteractNo.canceled += instance.OnInteractNo;
                @RunHold.started += instance.OnRunHold;
                @RunHold.performed += instance.OnRunHold;
                @RunHold.canceled += instance.OnRunHold;
                @CrouchTrigger.started += instance.OnCrouchTrigger;
                @CrouchTrigger.performed += instance.OnCrouchTrigger;
                @CrouchTrigger.canceled += instance.OnCrouchTrigger;
                @Radio1.started += instance.OnRadio1;
                @Radio1.performed += instance.OnRadio1;
                @Radio1.canceled += instance.OnRadio1;
                @Radio2.started += instance.OnRadio2;
                @Radio2.performed += instance.OnRadio2;
                @Radio2.canceled += instance.OnRadio2;
                @Radio3.started += instance.OnRadio3;
                @Radio3.performed += instance.OnRadio3;
                @Radio3.canceled += instance.OnRadio3;
                @Radio4.started += instance.OnRadio4;
                @Radio4.performed += instance.OnRadio4;
                @Radio4.canceled += instance.OnRadio4;
                @Radio5.started += instance.OnRadio5;
                @Radio5.performed += instance.OnRadio5;
                @Radio5.canceled += instance.OnRadio5;
                @RadioNext.started += instance.OnRadioNext;
                @RadioNext.performed += instance.OnRadioNext;
                @RadioNext.canceled += instance.OnRadioNext;
                @RadioBack.started += instance.OnRadioBack;
                @RadioBack.performed += instance.OnRadioBack;
                @RadioBack.canceled += instance.OnRadioBack;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Debug.started += instance.OnDebug;
                @Debug.performed += instance.OnDebug;
                @Debug.canceled += instance.OnDebug;
                @DebugF1.started += instance.OnDebugF1;
                @DebugF1.performed += instance.OnDebugF1;
                @DebugF1.canceled += instance.OnDebugF1;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Pointer;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_LeftClick;
    public struct UIActions
    {
        private @DefaultActions m_Wrapper;
        public UIActions(@DefaultActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pointer => m_Wrapper.m_UI_Pointer;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @LeftClick => m_Wrapper.m_UI_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Pointer.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPointer;
                @Pointer.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPointer;
                @Pointer.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPointer;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @LeftClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pointer.started += instance.OnPointer;
                @Pointer.performed += instance.OnPointer;
                @Pointer.canceled += instance.OnPointer;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_DefaultSchemeIndex = -1;
    public InputControlScheme DefaultScheme
    {
        get
        {
            if (m_DefaultSchemeIndex == -1) m_DefaultSchemeIndex = asset.FindControlSchemeIndex("Default");
            return asset.controlSchemes[m_DefaultSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnBlink(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnInteractYes(InputAction.CallbackContext context);
        void OnInteractHold(InputAction.CallbackContext context);
        void OnInteractNo(InputAction.CallbackContext context);
        void OnRunHold(InputAction.CallbackContext context);
        void OnCrouchTrigger(InputAction.CallbackContext context);
        void OnRadio1(InputAction.CallbackContext context);
        void OnRadio2(InputAction.CallbackContext context);
        void OnRadio3(InputAction.CallbackContext context);
        void OnRadio4(InputAction.CallbackContext context);
        void OnRadio5(InputAction.CallbackContext context);
        void OnRadioNext(InputAction.CallbackContext context);
        void OnRadioBack(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnDebug(InputAction.CallbackContext context);
        void OnDebugF1(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPointer(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
