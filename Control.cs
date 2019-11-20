using System;
using System.Collections.Generic;

namespace OscarAFernandez {
    public class Character : IEquatable<Character> // Lista de carácteres
    {
       
        public string Letter { get; set; }
       
        public string Number { get; set; }
        public int Repetitions { get; set; }
        
        public bool Equals(Character other)
        {
            if (other == null) return false;
            return (this.Number.Equals(other.Number));
        }
        public string getNumbers() {
            string numbers = this.Number;
            for(int x = 1; x < this.Repetitions; x++)
            {
                numbers = numbers+this.Number;
                    
            }
            
            return numbers;
        }

    }
    public class Control {
        List<Character> letters = new List<Character>();

        int number = 2;

        int repeticion = 1;

        public void Start() { // Iniciamos la lista
            string letterlist = "abcdefghijklmnopqrstuvwxyz ";
            
            for(int i = 0; i < letterlist.Length; i++) {
                letters.Add(new Character { Letter = letterlist[i].ToString(), Number = number.ToString(), Repetitions = repeticion  });
                if(repeticion == 3 || repeticion == 4) {
                    if(number == 7 && repeticion == 3 || number == 9 && repeticion == 3){
                        repeticion++;
                    } else { NextNumber(); }
                }
                else {
                    repeticion++;
                }
            }
        }

        void NextNumber() {  // Siguiente numero y restart del repetidor
            number++; repeticion = 1; 
            if(number == 10) { number = 0; }
        }

        public void findString(string text) { // Buscamos las letras en la lista y obtenemos el resultado
            string result = "";
            string lastnumber = "";
            for(int i = 0; i < text.Length; i++) {
                Character character = letters.Find(
                    delegate(Character chr)
                    {
                        return chr.Letter == text[i].ToString().ToLower();
                    }
                );
                string numbers = character.getNumbers();
                if(lastnumber == character.Number) {
                    result = result+" "+numbers;
                }
                else {
                    result = result+numbers;
                }
                lastnumber = character.Number;
            }
            Console.WriteLine("Resultado: "+result);
        }
        
        public bool IsLetter(string text) // Verifica si una cadena de texto contiene carácteres válidos (true = correcto, false = error)
        {
            bool success = true;
            for(int i = 0; i < text.Length; i++) {
                char c = text[i];
                if(!(c>='A' && c<='Z') && !(c>='a' && c<='z') && !(c == ' ')) {
                    success = false;
                }
            }
            return success;
        }
    }
}