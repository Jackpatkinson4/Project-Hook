using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public Image FillImage;
    private Slider _slider;
    public float Value = 0;
    // Start is called before the first frame update
    void Awake() {
        _slider = GetComponent<Slider>();
        Debug.Log(_slider == null);
    }
    // Update is called once per frame
    void Update()
    {
        FillImage.enabled = _slider.value > _slider.minValue + 0.01;

        _slider.value = Value / 100f;
    }
}
