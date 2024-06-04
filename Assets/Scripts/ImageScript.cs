using UnityEngine;
using UnityEngine.UI;

public class ImageScript: MonoBehaviour
{
    public GameObject image;
    public Sprite[] spriteArray;
    public Slider SliderSize;
    public Slider SliderRotation;

    private void Start()
    {
        // Hide the sliders at the beginning
        SliderSize.gameObject.SetActive(false);
        SliderRotation.gameObject.SetActive(false);
    }

    public void ChangeImage(int index)
    {
        if (index >= 0 && index < spriteArray.Length)
        {
            image.GetComponent<Image>().sprite = spriteArray[index];
        }
        else
        {
            Debug.LogWarning("Invalid index for sprite array!");
        }
    }

    public void ChangeSize()
    {
        float size = SliderSize.value;
        image.transform.localScale = new Vector3(size, size, 1f);
    }

    public void ChangeRotation()
    {
        float rotation = SliderRotation.value;
        image.transform.localRotation = Quaternion.Euler(0f, 0f, rotation * 360f);
    }

    // Show/hide sliders
    public void ToggleSliders(bool show)
    {
        SliderSize.gameObject.SetActive(show);
        SliderRotation.gameObject.SetActive(show);
    }
}
