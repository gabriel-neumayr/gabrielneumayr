using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zoo;
using Zoo.Landtier;
using Zoo.Wassertiere;

namespace Zoo
{
   
    class Menu
    {
        List<Tier> zoo = new List<Tier>();
        int userSelection = 0;
        Delfin delfin = new Delfin("D", 1, "Delfin");
        Wal wal = new Wal("W", 1, "Wal");
        Nashorn nashorn = new Nashorn("N", 1, "Nashorn");
        Elefant elefant = new Elefant("E", 1, "Elefant");

        public void ZooMenu()
        {
            do
            {
                ListMenu();
                userSelection = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                UserSelection();
                
                void UserSelection()
                        {
                    switch (userSelection)
                    {
                        case 1:
                            CreateAnimal();
                            break;
                        case 2:
                            SteckBrief();
                            break;
                        case 3:
                            ListOfAllAnimals();
                            break;
                        case 4:
                            SpecialFunction();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Falsche eingabe");
                            break;
                    }
                }

            } while (true);
        }
        private void SpecialFunction()
        {
            string animalName;
            for (int i = 0; i < zoo.Count; i++)
            {
                Console.WriteLine("Name: " + zoo[i].GetName() + " Kind: " + zoo[i].GetAnimalKind());
            }
            animalName = Console.ReadLine();
            Console.WriteLine();
            AnimalsCompare();

            void AnimalsCompare()
            {
                for (int i = 0; i < zoo.Count; i++)
                {
                    if (zoo[i].GetName() == animalName)
                    {
                        if (zoo[i].CompareTo(delfin) == 0)
                        {
                            delfin.DelfinSpecialFunc();
                        }
                        else if (zoo[i].CompareTo(wal) == 0)
                        {
                            wal.WalSpecialFunc();
                        }
                        else if (zoo[i].CompareTo(nashorn) == 0)
                        {
                            nashorn.NashornSpecialFunc();
                        }
                        else if (zoo[i].CompareTo(elefant) == 0)
                        {
                            elefant.ElefantSpecialFunc();
                        }

                    }

                }
            }
        }
        private void ListOfAllAnimals()
        {
            for (int i = 0; i < zoo.Count; i++)
            {
                Tier tier = zoo[i];
                Console.WriteLine("Name: " + zoo[i].GetName() + " Art: " + zoo[i].GetType().Name);
            }
        }
        private void SteckBrief()
        {
            string tier;
            Console.WriteLine("Von welchem Tier wollen sie den \"Steckbrief\" sehen?");

            for (int i = 0; i < zoo.Count; i++)
            {

                Console.WriteLine("Name: " + zoo[i].GetName() + " Art: " + zoo[i].GetAnimalKind());

            }
            tier = Console.ReadLine();

            for (int i = 0; i < zoo.Count; i++)
            {
                if (zoo[i].GetName() == tier)
                {
                    PrintSteckbrief(zoo[i]);
                }
            }   
        void PrintSteckbrief(Tier tier)
        {
            tier.Steckbrief(40,"12.23.1994");
        }

        }
        private void CreateAnimal()
        {
            string animalKind;
            string animalName;
            int capeability;

            Console.WriteLine("Welches Tier wollen sie haben? \n Deflin \n Wal\n Nashorn \n Elefant");
            animalKind = Console.ReadLine();
            animalKind.ToLower();
            Console.WriteLine("Name des Tier:");
            animalName = Console.ReadLine();

            Console.WriteLine("Geschwindigkeit/Tauchzeit:");
            capeability = Convert.ToInt32(Console.ReadLine());

            SwitchKind();

            void SwitchKind()
            {
                switch (animalKind)
                {
                    case "delfin":
                        zoo.Add(new Delfin(animalName, capeability, animalKind));
                        break;
                    
                    case "wal":
                        zoo.Add(new Wal(animalName, capeability, animalKind));
                        break;
                    
                    case "nashorn":
                        zoo.Add(new Nashorn(animalName, capeability, animalKind));
                        break;
                    
                    case "elefant":
                        zoo.Add(new Elefant(animalName, capeability, animalKind));
                        break;
                    default:
                        Console.WriteLine("Nicht zulässig versuchen sie es nocheinmal");
                        break;

                }
            }
        }
        private void ListMenu()
            {
                Console.WriteLine("Wählen sie aus dem Menü:");
                Console.WriteLine("1. Tier erstellen");
                Console.WriteLine("2. Anzeigen des \"Steckbrief\"");
                Console.WriteLine("3. Anzeigen des Tieres");
                Console.WriteLine("5. Fertig");
            

            }
    }
}

