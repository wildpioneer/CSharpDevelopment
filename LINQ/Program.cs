namespace LINQ;

public class Program
{
    static void Main()
    {
        // Testing Task
        /*
        TestTask testTask = new TestTask();
        testTask.Solve();
        */
        
        // Base Sytanx
        /*
        new BaseSyntax().RunQuerySyntax();
        new BaseSyntax().RunMethodSyntax();
        new BaseSyntax().RunStringExtention();
        */
        
        
        // Where
        new Where().RunQuerySyntax();
        new Where().RunMethodSyntax();
        
        // Select
        /*
        new Select().RunQuerySyntax();
        new Select().RunMethodSyntax();
        */
        
        // Два в одном
        //new TwoInOne().run();
        
        // Переменные
        /*
        new Variables().RunQuerySyntax();
        new Variables().RunMethodSyntax();
        */
        
        // Агрегация данных
        /*
        new DataAggregation().RunQuerySyntax(); 
        new DataAggregation().RunMethodSyntax(); 
        */
    }
}