using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Catalog
    {
        private static Catalog _instance;

        private Catalog()
        {
            Animals = new Animal[]
            {
                new Baboon(
                    birthDate: new DateTime(2021, 07, 21),
                    weight: new Weight(42),
                    habitat: Country.UnitedStatesOfAmerica,
                    tame: false,
                    wool: new Wool(WoolType.Curly, color: ConsoleColor.Black),
                    nickname: "Bob",
                    assColor: ConsoleColor.Red,
                    typeOfBaboon: TypeOfBaboon.Hamadryl),

                new Fox(
                    birthDate: new DateTime(2022, 01, 17),
                    weight: new Weight(32),
                    habitat: Country.Ukraine,
                    tame: true,
                    wool: new Wool(WoolType.Hairless, color: ConsoleColor.Red),
                    nickname: "Sister",
                    canineLength: new Length(2),
                    mustacheLength: new Length(12),
                    typeOfFox: TypeOfFox.Fenek),

                new Gorilla(
                    birthDate: new DateTime(2019, 11, 06),
                    weight: new Weight(95),
                    habitat: Country.UnitedStatesOfAmerica,
                    tame: true,
                    wool: new Wool(WoolType.Curly, color: ConsoleColor.Black),
                    nickname: "Tomas",
                    typeOfGorilla: TypeOfGorilla.Western),

                new Roe(
                    birthDate: new DateTime(2020, 01, 09),
                    weight: new Weight(88),
                    habitat: Country.Germany,
                    tame: false,
                    wool: new Wool(WoolType.Curly, color: ConsoleColor.Yellow),
                    nickname: "Lola",
                    horn: new Length(15),
                    typeOfRoe: TypeOfRoe.European),

                new Tiger(
                    birthDate: new DateTime(2011, 08, 08),
                    weight: new Weight(115),
                    habitat: Country.India,
                    tame: false,
                    wool: new Wool(WoolType.Hairless, color: ConsoleColor.White),
                    nickname: "Sherhan",
                    canineLength: new Length(5),
                    mustacheLength: new Length(15),
                    typeOfTiger: TypeOfTiger.Indochina),

                new Wolf(
                    birthDate: new DateTime(2022, 12, 19),
                    weight: new Weight(42),
                    habitat: Country.Ukraine,
                    tame: false,
                    wool: new Wool(WoolType.Hairless, color: ConsoleColor.Gray),
                    nickname: "Akella",
                    canineLength: new Length(4),
                    mustacheLength: new Length(5),
                    typeOfWolf: TypeOfWolf.Oriental)
            };
        }

        public Animal[] Animals { get; init; }

        public static Catalog GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Catalog();
            }

            return _instance;
        }
    }
}
