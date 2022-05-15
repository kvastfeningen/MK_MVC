namespace MK_MVC.Models
{
    public class TempCheck
    {
        
        public string Fever( double temp){
        

            if (temp <= 38)
            
                return "Du har inte feber";
            
            else
            
                return "Du har feber"!;
            

        }
    }
}
    