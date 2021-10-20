using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
        volumeSlider.value = GameManager.Instance.backgroundVolume;
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }
    void SetVolume(float volume)
    {
        GameManager.Instance.GetComponent<AudioSource>().volume = volume;
        GameManager.Instance.backgroundVolume = volume;
    }
}
