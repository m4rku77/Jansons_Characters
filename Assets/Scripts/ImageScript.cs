using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject character;
    public Sprite[] spriteArray;
    public Slider SliderSize;
    public Slider SliderRotation;

    private void Start()
    {
        // Ensure sliders are visible when the game starts
        SliderSize.gameObject.SetActive(true);
        SliderRotation.gameObject.SetActive(true);
    }

    public void ChangeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            character.GetComponent<Image>().sprite = spriteArray[index];
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
}
