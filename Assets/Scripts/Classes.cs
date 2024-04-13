using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    abstract class Pet
    {
        //properties
        public string name { get; set; }
        public char sex { get; set; }
        public byte age { get; set; }
        public bool needsGarden { get; set; }
        public bool okChildren { get; set; }
        public bool okCats { get; set; }
        public bool okDogs { get; set; }
        public string personality { get; set; }

        public abstract void getToKnow()
        {

        }
    }

    public class Dog : Pet
    {
        public Dog(string name, char sex)
        {
            name = name;
            sex = sex;
        }

        //properties
        public char size { get; set; }
    }

    public class Cat : Pet
    {
        public Cat(string name, char sex)
        {
            name = name;
            sex = sex;
        }
    }

    public class Family
    {
        public Family(Pet[] pets, byte size, byte children, string[] want, string housing)
        {
            pets = pets;
            size = size;
            children = children;
            want = want;
            housing = housing;
        }

        //properties
        public Pet[] pets { get; set; }
        public byte size { get; set; }
        public byte children { get; set; }
        public string[] want { get; set; }
        public string housing { get; set; }
    }
}
