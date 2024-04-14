using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    public abstract class Pet
    {
        //properties
        public string Name { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }
        public bool NeedsGarden { get; set; }
        public bool OkChildren { get; set; }
        public bool OkCats { get; set; }
        public bool OkDogs { get; set; }
        public string Personality { get; set; }
        public char Size { get; set; }

        
        /*public abstract void getToKnow()
        {

        }*/
    }

    public class Dog : Pet
    {
        public Dog(string name, char sex, char size)
        {
            this.Name = name;
            this.Sex = sex;
            this.Size = size;
        }

        //properties
        //public char Size { get; set; }

        //methods
        public void AddDog(string name, char sex, char size)
        {
            DataManager.Instance.refugePets.Add(new Dog(name, sex, size));
        }

        public void AddDog(Dog dog)
        {
            DataManager.Instance.refugePets.Add(dog);
        }
    }

    public class Cat : Pet
    {
        public Cat(string name, char sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public void AddCat(string name, char sex)
        {
            DataManager.Instance.refugePets.Add(new Cat(name, sex));
        }
    }

    public class Family
    {
        public Family(Pet[] pets, byte size, byte children, string[] want, string housing)
        {
            this.Pets = pets;
            this.Size = size;
            this.Children = children;
            this.Want = want;
            this.Housing = housing;
        }

        //properties
        public Pet[] Pets { get; set; }
        public byte Size { get; }
        public byte Children { get; }
        public string[] Want { get; }
        public string Housing { get; }
    }

    [System.Serializable]
    public class Possibilites
    {
        public List<string> PetNames;
        public List<char> Sexes;
        public List<int> PetAges;
        public List<string> PetPersonalities;
        public List<char> DogSizes;
        public List<int> FamilySizes;
        public List<string> FamilyWants;
        public List<string> FamilyHousing;

        /*public static Possibilites getFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<Possibilites>(jsonString);
        }*/
    }
}
