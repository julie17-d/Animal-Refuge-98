using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CurrentPetsWindow : MonoBehaviour/*, IPointerClickHandler*/
{
    public static void PopulatePetsWindow()
    {
        for (int i = 0; i < DataManager.Instance.refugePets.Count; i++)
        {
            GameObject pet = new();
            pet.transform.parent = GameObject.Find("Animals").transform;
            pet.AddComponent<TextMeshProUGUI>();
            TextMeshProUGUI textMesh = pet.GetComponent<TextMeshProUGUI>();
            Classes.Pet petInfos = DataManager.Instance.refugePets[i];
            if (DataManager.Instance.refugePets[i] is Classes.Dog)
            {
                string size;
                switch (petInfos.Size)
                {
                    case 's':
                         size = "small";
                        break;
                    case 'm':
                        size = "medium";
                        break;
                    case 'l':
                        size = "large";
                        break;
                    default:
                        size = "bug";
                        break;
                }
                textMesh.text = $"{petInfos.Name}, {petInfos.Age} years old {size} dog, {petInfos.Sex.ToString().ToUpper()}.";
            } else if (DataManager.Instance.refugePets[i] is Classes.Cat)
            {
                textMesh.text = $"{petInfos.Name}, {petInfos.Age} years old cat, {petInfos.Sex.ToString().ToUpper()}.";
            }
            textMesh.rectTransform.anchoredPosition = new Vector2(-105f, (90f - 45*i));
            textMesh.color = new Color(0, 0, 0);
            textMesh.fontSize = 30;
            textMesh.rectTransform.sizeDelta = new Vector2(1500f, 70f);
        }
    }

    /*// add callbacks in the inspector like for buttons
    public UnityEvent onClick;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Debug.Log(name + " Game Object Clicked!", this);

        // invoke your event
        onClick.Invoke();
    }*/

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
