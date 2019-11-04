using System.Collections.Generic;
using Zoo.Models;

namespace Zoo
{
    public class Dicionario 
    {
        public static Dictionary<int, Animais> DicionarioAnimal = new Dictionary <int, Animais>()
        {
            {1, new Arara()},
            {2, new Chimpanze()},
            {3, new Golfinho()},
            {4, new Leao()},
            {5, new Orangotango()},
            {6, new Pinguim()},
            {7, new Tartaruga()},
            {8, new Arara()},
            {9, new Arara()},
        };
    }
}