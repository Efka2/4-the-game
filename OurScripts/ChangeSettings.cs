using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class ChangeSettings : MonoBehaviour
{

    public Slider sensitivitySlider;

    public void ApplySensitivity()
    {
        GetComponent<FirstPersonController>().ChangeMouseSensitivity(sensitivitySlider.value, sensitivitySlider.value);
    }
}