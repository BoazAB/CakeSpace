using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volume : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Slider volSlider = null;
    [SerializeField] public Text volTextUI= null;
    private void Start(){
        loadVal();
    }
    public void VolumeSlider(float vol){
        volTextUI.text = vol.ToString("0");
    }
    public void SaveVolumeButton(){
        float volValue = volSlider.value;
        PlayerPrefs.SetFloat("volValue", volValue);
        loadVal();
    }
    void loadVal(){
        float volValue = PlayerPrefs.GetFloat("volVal");
        volSlider.value = volValue;
        AudioListener.volume = volValue;
    }
}
