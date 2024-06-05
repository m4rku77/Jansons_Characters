using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject character;
    public Sprite[] spriteArray;
    public Slider SliderSize;
    public Slider SliderRotation;

    public GameObject body1;
    public GameObject body2;
    public GameObject body3;

    public GameObject Kurpes1;
    public GameObject Kurpes2;
    public GameObject Kurpes3;

    public GameObject RozaHelmet;
    public GameObject FireHelmet;
    public GameObject StoneHlemet;

    public Text InfoText; // Reference to the Text component in the ScrollView

    private bool bodyShown = true;
    private bool kurpesShown = true;
    private bool helmetShown = true;

    private void Start()
    {
        // Ensure sliders are visible when the game starts
        SliderSize.gameObject.SetActive(true);
        SliderRotation.gameObject.SetActive(true);
    }

    public void showBody(bool value)
    {
        body1.SetActive(value);
        body2.SetActive(value);
        body3.SetActive(value);
    }

    public void showKurpes(bool value)
    {
        Kurpes1.SetActive(value);
        Kurpes2.SetActive(value);
        Kurpes3.SetActive(value);
    }

    public void showHelmet(bool value)
    {
        RozaHelmet.SetActive(value);
        FireHelmet.SetActive(value);
        StoneHlemet.SetActive(value);
    }

    public void ToggleBody(bool value)
    {
        if (value)
        {
            showBody(bodyShown);
            bodyShown = !bodyShown; // Toggle the state
        }
        else
        {
            showBody(false); // Hide the body GameObjects
            bodyShown = true; // Reset the state
        }
    }

    public void ToggleKurpes(bool value)
    {
        if (value)
        {
            showKurpes(kurpesShown);
            kurpesShown = !kurpesShown; // Toggle the state
        }
        else
        {
            showKurpes(false); // Hide the kurpes GameObjects
            kurpesShown = true; // Reset the state
        }
    }

    public void ToggleHelmet(bool value)
    {
        if (value)
        {
            showHelmet(helmetShown);
            helmetShown = !helmetShown; // Toggle the state
        }
        else
        {
            showHelmet(false); // Hide the helmet GameObjects
            helmetShown = true; // Reset the state
        }
    }

    public void ChangeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            character.GetComponent<Image>().sprite = spriteArray[index];
            UpdateInfoText(index); // Update the information text
        }
        else
        {
            Debug.LogWarning("Invalid index for sprite array!");
        }
    }

    public void ChangeSize()
    {
        float size = SliderSize.value;
        character.transform.localScale = new Vector3(size, size, 1f);
    }

    public void ChangeRotation()
    {
        float rotation = SliderRotation.value;
        character.transform.localRotation = Quaternion.Euler(0f, 0f, rotation * 360f);
    }

    // Show/hide sliders
    public void ToggleSliders(bool show)
    {
        SliderSize.gameObject.SetActive(show);
        SliderRotation.gameObject.SetActive(show);
    }

    // Method to update the information text based on the selected skin
    private void UpdateInfoText(int index)
    {
        string[] infoTexts = {
            "Default: Hei! Esmu parasts cilv?ks, kurš dara cilv?c?gas lietas! ;] ",
            "Wizard: UUUUuuUUUuU!!!! Ar mani nevajag jokoties, es m?dzu nodarboties ar ma?iju un noburt tos, kuri man nepat?k!",
            
        };

        if (index >= 0 && index < infoTexts.Length)
        {
            InfoText.text = infoTexts[index];
        }
        else
        {
            InfoText.text = "No information available.";
        }
    }
}
