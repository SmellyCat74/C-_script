// See https://aka.ms/new-console-template for more information
using System.Net.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;

public partial class Program{
        public int num1;
        public int num2;
        public int total;
        public string text1 = " ";
        public string text2 = " ";
        public bool cond;
        public string userinput = "";
        

        
        
  


      public static void Main(){

        Program program = new Program();
        program.add_nums();
        string [] list = {"Hello","User.","This","is","a","Calculator",
        "that","will","help","you","with","math","and","science","problems."}

      
    }
    public void add_nums(){

        cond = true; 


        while(cond){
            text1 = "please enter the first integers";
            Console.WriteLine(text1);
            num1 = Convert.ToInt32(Console.ReadLine());
            text2 = "please enter the second integers";
            Console.WriteLine(text2);
            num2 =  Convert.ToInt32(Console.ReadLine());
            total = num1 + num2;
            Console.WriteLine("the total is:");
            Console.WriteLine(total);

            Console.WriteLine("please enter yes to continue or no to quit ");

            this.userinput = Console.ReadLine();
            
            if(userinput == "no"){
                cond = false;
            }
            else{
                Console.WriteLine("Goodbye!");
            }


        }
        

    }

}
      
