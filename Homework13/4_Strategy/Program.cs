using System;

namespace _4_Strategy
{
    /* Strategy

        დაწერეთ პროგრამა რომელიც ფაილის გაფართოების მიხედვით გადაწყვეტს რომელი მოქმედება უნდა ჩაატაროს . 
        თუ ფაილის იქნება .zip მაშინ  მაშინ  უნდა გაუკეთოს ამ ფაილს unzip და შეინახოს backup დირექტორიაში ( თუ არ არსებობს უნდა შეიქმნას ) 

        თუ ფაილი არის .json  კონსოლში დაბეჭდოს   ის რაც წერია ამ ფაილში 

        თუ ფაილი არის  .txt  წაშალოს დირექტორიიდან
        */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }




    abstract class StrategyFile
    {
        public abstract void fileName();
    }

    //zip
    class ZipStrategyFile : StrategyFile 
    {

    }

    //.json
    class JsonStrategyFile : StrategyFile 
    {

    }

    //.txt
    class TxtStrategyFile : StrategyFile
    {

    }
}
