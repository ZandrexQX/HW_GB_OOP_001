using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_GB_OOP_001
{
    public enum Gender
    {
        Male,
        Female
    }

    public class FamilyMember
    {
        public FamilyMember()
        {
            this.Mother = null;
            this.Father = null;
        }
        public FamilyMember(string name, Gender sex)
        {
            this.Mother = null;
            this.Father = null;
            this.Name = name;
            this.Sex = sex;
        }

        public FamilyMember(string name, Gender sex, FamilyMember mother, FamilyMember father)
        {
            this.Mother = mother;
            this.Father = father;
            this.Name = name;
            this.Sex = sex;
        }
        internal FamilyMember Mother { get; set; }
        internal FamilyMember Father { get; set; }
        internal string Name { get; set; }
        internal Gender Sex { get; set; }

        public virtual void Info(int indent = 0)
        {
            Console.WriteLine($"{new String('-', indent)}Имя {this.Name}");
        }
        public virtual void Print(int indent = 0)
        {
            Info(indent);
        }


    }

    public class AdultFamilyMember : FamilyMember
    {
        public AdultFamilyMember()
        {
            this.Mother = null;
            this.Father = null;
        }
        public AdultFamilyMember(string name, Gender sex)
        {
            this.Mother = null;
            this.Father = null;
            this.Name = name;
            this.Sex = sex;
        }

        public AdultFamilyMember(string name, Gender sex, FamilyMember mother, FamilyMember father)
        {
            this.Mother = mother;
            this.Father = father;
            this.Name = name;
            this.Sex = sex;
        }
        private List<FamilyMember> Children { get; set; } = new List<FamilyMember>();
        private AdultFamilyMember Spouse;
        public override void Print(int indent = 0)
        {
            base.Print(indent);

            foreach (var child in Children)
                child.Print(indent * 2);
        }
        public override void Info(int indent = 0)
        {
            if (Spouse != null)
            {
                Console.WriteLine($"{new String('-', indent)}Имя {this.Name} | Супруг(а) {Spouse.Name}");
            }
            else
            {
                Console.WriteLine($"{new String('-', indent)}Имя {this.Name}");
            }
        }

        public void AddChildren(FamilyMember children)
        {
            this.Children.Add(children);
        }

        public void AddSpouse(AdultFamilyMember spouse)
        {
            this.Spouse = spouse;
        }

    }
}
