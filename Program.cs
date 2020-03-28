using System;

namespace _5thLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Class Work 
            
            {
                Console.Write("A:"); 
                int a = int.Parse(Console.ReadLine());
                Console.Write("B:"); 
                int b = int.Parse(Console.ReadLine());
                int sum = 0; 
                while ( a <= b ){
                    sum+=a; 
                    a++; 
                } 
                System.Console.WriteLine("Sum = " + sum);
            
            }
            int tries = 5; 
            string word = "Ilhom";  
            int n = 0;  
            while ( tries > 0 ){
                
                bool t = false; 
                Console.Write("Letter:");
                char choice = char.Parse(Console.ReadLine());
                string q = choice.ToString(); 
                q = q.ToLower(); 
                choice 
                = char.Parse(q); 
                string wordInput = word.ToLower(); 
                for ( int i = 0; i < word.Length; i++ ){
                    if ( word.Contains(choice) ){
                        
                        System.Console.WriteLine("Right!!");
                        n++; 
                        t = true;
                        break;        
                    } 
                }
                if ( word.Length == n ){
                    System.Console.WriteLine($"You did it.... The word is {word}");
                    break; 
                }
                if ( !t ){
                    tries--; 
                }
            }
            Console.ReadKey(); 

        }
    }
}
