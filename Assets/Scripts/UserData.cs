using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    [NonSerialized] public string Name;
    [NonSerialized] public string Controller;

    public InputField NameField;
    public Dropdown ControllerDropDown;
    public InputField ControllerField;
    public UnityEngine.UI.Button Validate;
    public TestManager Test;

    public void ValueChanged()
    {
        bool ready = NameField.text.Length != 0;
        
        if (ControllerDropDown.captionText.text == "Select a Controller"
            || ControllerDropDown.captionText.text == "Other")
        {
            ControllerField.gameObject.SetActive(ControllerDropDown.captionText.text == "Other");
            ready &= ControllerField.text.Length != 0;
        }
        else
        {
            ControllerField.gameObject.SetActive(false);
        }

        Validate.interactable = ready;
    }

    public void Hide()
    {
        Name = NameField.text;
        Controller = (ControllerDropDown.captionText.text != "Select a Controller"
                      && ControllerDropDown.captionText.text != "Other")
            ? ControllerDropDown.captionText.text
            : ControllerField.text;
        FindObjectOfType<Canvas>().enabled = false;
        Test.gameObject.SetActive(true);
    }
}
