using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    [SerializeField]
    Slider volume;

    // Start is called before the first frame update
    void Start()
    {
        volume.onValueChanged.AddListener(delegate{ handleValueChange(volume.value, volume.maxValue); });
    }

    void handleValueChange(float val,float maxVal)
    {
        OptionManager.volume = val / maxVal;
        Debug.Log(OptionManager.volume);
    }

    
}
