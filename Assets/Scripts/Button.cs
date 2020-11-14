using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public enum ButtonPosition
{
    Up, Down, Left, Right
}

public enum IconType
{
    PlayStation, Xbox, Space, Any
}

[CreateAssetMenu]
public class Button : ScriptableObject
{
    public Sprite Sprite;
    public IconType IconType;
    public ButtonPosition ButtonPosition;
}

[CreateAssetMenu]
public class ButtonsManager : ScriptableObject
{
    public static ButtonsManager Instance;

    private static Button lastButton;

    public List<Button> buttons;
    public Button firstButton;
    
    private void Awake()
    {
        if (Instance) Destroy(this);
        else Instance = this;
    }

    public Button GetRandomButton(IconType iconType = IconType.Any)
    {
        List<Button> desiredButtons = buttons.Where(b => b != lastButton).ToList();
        if (iconType != IconType.Any) 
            desiredButtons = desiredButtons.Where(b => b.IconType == iconType).ToList();
        
        return lastButton = desiredButtons[Random.Range(0, desiredButtons.Count)];
    }

    public Button GetFirstButton()
    {
        return firstButton;
    }
}