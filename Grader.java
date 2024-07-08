public class Grader{
public static void main (String[]args){
double marks = -1;

if (marks>=93 && marks<=100 ){
System.out.println(" Grade is A. PASS");
            
        } else if (marks>=85 && marks<=92) {
           System.out.println(" Grade is B .PASS");
        } else if (marks>=80 && marks<=84) {
           System.out.println(" Grade is C. PASS");
        } else if (marks>=75 && marks<=79) {
           System.out.println(" Grade is D .PASS");
         }else if (marks < 75 && marks >= 0) {
            System.out.println("Grade is E. Fail exam.");
        } else {
            System.out.println("Unknown value");
        }
}
}



     