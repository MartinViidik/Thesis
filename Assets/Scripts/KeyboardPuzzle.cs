using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class KeyboardPuzzle : MonoBehaviour
{
    public string code;
    private InputField input;
    public GameObject Door;

    public void ClickKey(string character)
    {
        input.text += character;
    }

    public void Backspace()
    {
        if (input.text.Length > 0)
        {
            input.text = input.text.Substring(0, input.text.Length - 1);
        }
    }

    public void Enter()
    {
        VRTK_Logger.Info("You've typed [" + input.text + "]");
        if (input.text == code)
        {
            input.text = "Correct, you may escape now";
            Door.GetComponent<VRTK_InteractableObject>().isGrabbable = true;
            Door.GetComponent<Rigidbody>().isKinematic = false;
        } else {
            input.text = "";
        }
    }

    private void Start()
    {
        input = GetComponentInChildren<InputField>();
    }
}