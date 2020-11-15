using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplayersQueue : MonoBehaviour
{
    private List<ButtonDisplayer> buttons;
    private float buttonWidth;
    private Camera cam;
    
    public void CreateButtonDisplayers(int size)
    {
        cam = Camera.main;
        buttons = new List<ButtonDisplayer>();

        float padding = Screen.width * 0.1f; 
        float displayArea = Screen.width  - padding * 2;
        
        buttonWidth = (displayArea * 2) / (size * 3);
        
        for (int button = 0; button < size; button++)
        {
            GameObject newButtonDisplayer = new GameObject(
                "ButtonDisplayer"+button, typeof(ButtonDisplayer));
            newButtonDisplayer.transform.parent = transform;
            newButtonDisplayer.transform.localPosition = cam.ScreenToWorldPoint(
                new Vector3(padding + (float) (button + 0.5) * displayArea / size, cam.pixelHeight/2, 0));
            newButtonDisplayer.transform.localPosition += new Vector3(0, 0, 1);
            buttons.Add(newButtonDisplayer.GetComponent<ButtonDisplayer>());
        }
    }

    public void SetSprite(int button, Sprite sprite)
    {
        buttons[button].SetSprite(sprite);
        float spriteLargestBorder = Math.Max(sprite.rect.width, sprite.rect.height);
        float scale = buttonWidth / spriteLargestBorder;
        buttons[button].transform.localScale = new Vector3(scale, scale, 0);
        buttons[button].gameObject.SetActive(true);
    }

    public void SetDone(int button)
    {
        buttons[button].gameObject.SetActive(false);
    }
}
