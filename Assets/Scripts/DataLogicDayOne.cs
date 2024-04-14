using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using UnityEngine;
using Random = UnityEngine.Random;

public class DataLogicDayOne : MonoBehaviour
{
    List<Classes.Pet> newPets;
    string GetRandomValue(List<string> possibilitiesField)
    {
        int randomIndex = Random.Range(0, possibilitiesField.Count);
        string value = possibilitiesField[randomIndex];
        return value;
    }

    char GetRandomValue(List<char> possibilitiesField)
    {
        int randomIndex = Random.Range(0, possibilitiesField.Count);
        char value = possibilitiesField[randomIndex];
        return value;
    }

    bool GetRandomBool()
    {
        return (Random.value > 0.5f);
    }

    List<Classes.Pet> CreateNewPets(Classes.Possibilites possibilities)
    {
        List<Classes.Pet> newPets = new();
        int numberOfNewPets = Random.Range(1, 6);
        for (int i = 0; i < numberOfNewPets; i++)
        {
            string petName = GetRandomValue(possibilities.PetNames);
            char sex = GetRandomValue(possibilities.Sexes);
            int age = Random.Range(1, 11);
            string personality = GetRandomValue(possibilities.PetPersonalities);
            string species = GetRandomValue(possibilities.FamilyWants);
            if (species == "dog")
            {
                char dogSize = GetRandomValue(possibilities.DogSizes);
                Classes.Dog newPet = new(petName, sex, dogSize)
                {
                    Age = age,
                    Personality = personality,
                    NeedsGarden = GetRandomBool(),
                    OkChildren = GetRandomBool(),
                    OkDogs = GetRandomBool(),
                    OkCats = GetRandomBool()
                };
                newPets.Add(newPet);
            }
            else
            {
                Classes.Cat newPet = new(petName, sex)
                {
                    Age = age,
                    Personality = personality,
                    NeedsGarden = GetRandomBool(),
                    OkChildren = GetRandomBool(),
                    OkDogs = GetRandomBool(),
                    OkCats = GetRandomBool()
                };
                newPets.Add(newPet);
            }
        }
        return newPets;
    }

    // Start is called before the first frame update
    void Start()
    {
        string path = Application.streamingAssetsPath + "/possibilities.json";
        string jsonString = File.ReadAllText(path);
        Classes.Possibilites possibilities = JsonConvert.DeserializeObject<Classes.Possibilites>(jsonString);
        newPets = CreateNewPets(possibilities);
        DataManager.Instance.refugePets.AddRange(newPets);
        CurrentPetsWindow.PopulatePetsWindow();
        //CurrentPetsWindow.OnPointerClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
