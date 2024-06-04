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
        int gadsValue = int.Parse(gads.text); // Parse the input string to an integer
        int age = 2024 - gadsValue; // Calculate age by subtracting birth year from current year

        inputField.text = "Terarists - " + vardsText + ", ir " + age + " gadus vecs!"; // Display the result
    }
}
