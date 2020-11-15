using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class ButtonsManager : ScriptableObject
{
    public static ButtonsManager Instance;

    private static Button lastButton;

    public List<Button> buttons;
    public Button firstButton;
    
    private ButtonsManager()
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