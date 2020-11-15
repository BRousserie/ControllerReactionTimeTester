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