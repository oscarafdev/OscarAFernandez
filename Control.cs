using System;
using System.Collections.Generic;

namespace OscarAFernandez {
    public class Button : IEquatable<Button>
    {
       
        public string Letter { get; set; }
       
        public string Number { get; set; }
        public int Repetitions { get; set; }
        
        public bool Equals(Button other)
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
        List<Button> letters = new List<Button>();
        int number = 2;
        int repeticion = 1;
        public void Start() {
            string letterlist = "abcdefghijklmnopqrstuvwxyz ";
            
            for(int i = 0; i < letterlist.Length; i++) {
                letters.Add(new Button { Letter = letterlist[i].ToString(), Number = number.ToString(), Repetitions = repeticion  });
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
        public void findString(string text) {
            string result = "";
            string lastnumber = "";
            for(int i = 0; i < text.Length; i++) {
                Button button = letters.Find(
                    delegate(Button btn)
                    {
                        return btn.Letter == text[i].ToString().ToLower();
                    }
                );
                string numbers = button.getNumbers();
                if(lastnumber == button.Number) {
                    result = result+" "+numbers;
                }
                else {
                    result = result+numbers;
                }
                lastnumber = button.Number;
            }
            Console.WriteLine("Presiona las teclas: "+result);
        }
        void NextNumber() { 
            number++; repeticion = 1; 
            if(number == 10) { number = 0; }
        }
    }
}