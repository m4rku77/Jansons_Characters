using UnityEngine;
using TMPro;

public class ShowTextScript : MonoBehaviour
{
    public TMP_InputField vards;
    public TMP_InputField gads;
    public TMP_InputField inputField;

    public void GetText()
    {
        string vardsText = vards.text;
        string gadsText = gads.text;

        inputField.text = "Vards: " + vardsText + ", Gads: " + gadsText;
    }
}
