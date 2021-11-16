using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleButton : MonoBehaviour
{
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(() => OnClick_Play());
    }

    public void OnClick_Play()
    {
        print("On click button play");
    }
}
