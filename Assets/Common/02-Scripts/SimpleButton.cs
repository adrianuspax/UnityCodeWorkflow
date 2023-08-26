using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleButton : MonoBehaviour
{
    [SerializeField] private Button buttonA;
    [SerializeField] private bool isPressed;

    private void Awake()
    {
        buttonA.onClick.AddListener(() => SeBehaviour(isPressed = !isPressed));
    }

    public void Start()
    {
        SeBehaviour(false);
    }

    public void SeBehaviour(bool isPressed)
    {
        buttonA.image.color = isPressed ? Color.green : Color.white;

        if (isPressed != this.isPressed)
        {
            this.isPressed = isPressed;
        }
    }
}
