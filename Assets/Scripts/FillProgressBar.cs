using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FillProgressBar : MonoBehaviour
{
    [SerializeField] private int numberOfAdoptionsToday;
    [SerializeField] private GameObject fill;
    [SerializeField] private GameObject percentage;
    private int adoptionsCompleted = 1;
    private UnityEngine.UI.Image fillImage;
    private TextMeshProUGUI percentageText;

    // Start is called before the first frame update
    void Start()
    {
        fillImage = fill.GetComponentInChildren<UnityEngine.UI.Image>();
        percentageText = percentage.GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float percentsOfAdoptionsComplete = adoptionsCompleted * 100 / numberOfAdoptionsToday;
        fillImage.fillAmount = percentsOfAdoptionsComplete;
        percentageText.text = percentsOfAdoptionsComplete.ToString() + "%";
    }
}
