using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    public abstract class Pet
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

        
        
        /*public abstract void getToKnow()
        {

        }*/
    }

    public class Dog : Pet
    {
        public Dog(string name, char sex, char size)
        {
            this.name = name;
            this.sex = sex;
            this.size = size;
        }

        //properties
        public char size { get; set; }
    }

    public class Cat : Pet
    {
        public Cat(string name, char sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }

    public class Family
    {
        public Family(Pet[] pets, byte size, byte children, string[] want, string housing)
        {
            this.pets = pets;
            this.size = size;
            this.children = children;
            this.want = want;
            this.housing = housing;
        }

        //properties
        public Pet[] pets { get; set; }
        public byte size { get; }
        public byte children { get; }
        public string[] want { get; }
        public string housing { get; }
    }
}
