public class Program
{
    public static void Main(string[] args)
    {
        Queue<char> Flower = new Queue<char>();
        char flower = 'x';
        int check = 0;
        char SteeringWheel = 'y';
        int i = 0;
        
            while (flower == 'J' || flower == 'G' || flower == 'O' || flower == 'R' || flower == 'x')
            {
                flower = char.Parse(Console.ReadLine());
            if (flower == 'J')
            {
                if (flower != SteeringWheel)
                {
                    Flower.Push('J');
                    check++;
                    SteeringWheel = 'z';
                }
                else
                {
                    Console.WriteLine("Invalid patten");

                }
            }
            else if(flower == 'G')
            {
             
                    if(flower != SteeringWheel)
                    {
                        Flower.Push('G');
                        SteeringWheel = 'z';
                        check++;
                        i++;
                    }
                
                else if(i>3)
                {
                    Console.WriteLine("invalid patten");
    
                }
                else
                {
                    Console.Write("Invalid patten");
            
                }
            }
            else if (flower == 'O')
            {
                if(flower != SteeringWheel)
                {
                    Flower.Push('O');
                    SteeringWheel = 'z';
                    check++;
                }
                else
                {
                    Console.WriteLine("Invalid patten");
                
                }
            }
            else if(flower == 'R')
            {
                if(check == 0)
                {
                    Console.WriteLine("Invalid patten");
                }
                else
                {
                    Flower.Push('R');
                    SteeringWheel = 'z';
                    SteeringWheel = Flower.Get(Flower.GetLength()-2);
                    check++;    
                }
            }
        }
       
        for(int n = 0;n<Flower.GetLength();n++)
            {
                Console.Write("{0}",Flower.Get(n));
            }
            
    }   
}