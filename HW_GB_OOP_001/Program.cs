namespace HW_GB_OOP_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grandMother1 = new AdultFamilyMember("Maria", Gender.Female);
            var grandFather1 = new AdultFamilyMember("Petr", Gender.Male);
            var grandMother2 = new AdultFamilyMember("Svetlana", Gender.Female);
            var grandFather2 = new AdultFamilyMember("Igor", Gender.Male);
            var mother = new AdultFamilyMember("Elena", Gender.Female, grandMother1, grandFather1);
            var father = new AdultFamilyMember("Vasiliy", Gender.Male, grandMother2, grandFather2);
            var son = new FamilyMember("Ivan", Gender.Male, mother, father);

            grandMother1.AddChildren(mother);
            grandMother2.AddChildren(father);
            grandFather1.AddChildren(mother);
            grandFather2.AddChildren(father);
            mother.AddChildren(son);
            father.AddChildren(son);
            grandFather1.AddSpouse(grandMother1);
            mother.AddSpouse(father);

            grandFather1.Print(1);

        }
    }
}