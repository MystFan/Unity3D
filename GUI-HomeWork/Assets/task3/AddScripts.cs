using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddScripts : MonoBehaviour {

	// Use this for initialization
    public Button button;
    public Slider slider;
    private float value = 0;
    private bool isMoving = false;
	void Start () {
        button.onClick.AddListener(ChangeValue);
	}

    public void ChangeValue()
    {
        if (isMoving)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
            this.value = 50f;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (slider.value < slider.maxValue && isMoving)
        {
            slider.value += (Time.deltaTime * value);
        }
        if (slider.value == slider.maxValue)
        {
            slider.value = 0;
        }
	}

}
