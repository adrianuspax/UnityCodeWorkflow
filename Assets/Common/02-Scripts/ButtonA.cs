using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonA : MonoBehaviour
{
    [SerializeField] private Button buttonA;
    [SerializeField] private bool nextPressure;

    private void Awake()
    {
        buttonA.onClick.AddListener(() => ButtonABehaviour(nextPressure));
    }

    public void Start()
    {
        ButtonABehaviour(false);
    }

    public void ButtonABehaviour(bool isPressed)
    {
        buttonA.image.color = nextPressure ? Color.green : Color.white;
        nextPressure = !isPressed;
    }
}
