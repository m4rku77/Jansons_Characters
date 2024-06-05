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

    public Text InfoText;

    public AudioClip sound0; // Audio clip for character 0
    public AudioClip sound1; // Audio clip for character 1

    private AudioSource audioSource;

    private bool bodyShown = true;
    private bool kurpesShown = true;
    private bool helmetShown = true;

    private void Start()
    {
        SliderSize.gameObject.SetActive(true);
        SliderRotation.gameObject.SetActive(true);

        audioSource = character.AddComponent<AudioSource>();
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
            bodyShown = !bodyShown;
        }
        else
        {
            showBody(false);
            bodyShown = true;
        }
    }

    public void ToggleKurpes(bool value)
    {
        if (value)
        {
            showKurpes(kurpesShown);
            kurpesShown = !kurpesShown;
        }
        else
        {
            showKurpes(false);
            kurpesShown = true;
        }
    }

    public void ToggleHelmet(bool value)
    {
        if (value)
        {
            showHelmet(helmetShown);
            helmetShown = !helmetShown;
        }
        else
        {
            showHelmet(false);
            helmetShown = true;
        }
    }

    public void ChangeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            character.GetComponent<Image>().sprite = spriteArray[index];
            UpdateInfoText(index);
            PlayCharacterSound(index); // Play the sound for the selected character
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

    public void ToggleSliders(bool show)
    {
        SliderSize.gameObject.SetActive(show);
        SliderRotation.gameObject.SetActive(show);
    }

    private void UpdateInfoText(int index)
    {
        string[] infoTexts = {
            "Default: Hei! Esmu parasts cilveks, kurs dara cilvecigas lietas! ;] ",
            "Wizard: UUUUuuUUUuU!!!! Ar mani nevajag jokoties, es medzu nodarboties ar magiju un noburt tos, kuri man nepatik!",
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

    private void PlayCharacterSound(int index)
    {
        if (index == 0)
        {
            audioSource.clip = sound0;
        }
        else if (index == 1)
        {
            audioSource.clip = sound1;
        }

        if (audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}
