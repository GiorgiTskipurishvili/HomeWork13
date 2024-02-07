using System;
using System.Net.Http;

namespace _2_Proxy_Pattern
{
    /*Proxy Pattern
    შექმენით აპლიკაცია რომელიც განასხვავებს ვალდებულებებს მთავარი მსახიობს და მის შემცვლელს (კასკადიორს შორის )

    შექმენი კლასი მთავარი მსახიობი რომლის ძირითადი ვალდებულება არის მარტივ სცენებში გადაღება .

    კლასი კასკადიორი რომლის ვალდებულება არის ფილმში გადაღება და ასევე რთული და საშიში მოქმედებების ჩატარება .*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var actor = new Proxy();
            actor.RequestSimpleScene();
        }
    }

    public interface IActor
    {
        public void RequestSimpleScene();
    }


    public class MainActor : IActor
    {
        public void RequestSimpleScene()
        {
            Console.WriteLine("Simple perform by main actor");
        }
    }


    public interface ICascadior
    {
        public void RequestCascadior();
    }

    public class Cascadior: ICascadior
    {
        public void RequestCascadior()
        {
            Console.WriteLine("Performs difficult and dangerous  actions");
        }
    }


    //Proxy
    class Proxy : IActor
    {
        private MainActor mainActor = new MainActor();


        public void RequestSimpleScene()
        {
            mainActor.RequestSimpleScene();

        }
    }

}







//First Wrote Code 

//using System;
//using System.Net.Http;

//namespace _2_Proxy_Pattern
//{
//    /*Proxy Pattern
//    შექმენით აპლიკაცია რომელიც განასხვავებს ვალდებულებებს მთავარი მსახიობს და მის შემცვლელს (კასკადიორს შორის )

//    შექმენი კლასი მთავარი მსახიობი რომლის ძირითადი ვალდებულება არის მარტივ სცენებში გადაღება .

//    კლასი კასკადიორი რომლის ვალდებულება არის ფილმში გადაღება და ასევე რთული და საშიში მოქმედებების ჩატარება .*/
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var actor = new Proxy();
//            actor.RequestSimpleScene();
//        }
//    }

//    abstract class IActor
//    {
//        public abstract void RequestSimpleScene();
//    }


//    class MainActor : IActor
//    {
//        public override void RequestSimpleScene()
//        {
//            Console.WriteLine("Simple perform by main actor");
//        }
//    }


//    abstract class ICascadior
//    {
//        public abstract void RequestCascadior();
//    }

//    class Cascadior : ICascadior
//    {
//        public override void RequestCascadior()
//        {
//            Console.WriteLine("Performs difficult and dangerous  actions");
//        }
//    }


//    //Proxy
//    class Proxy : IActor
//    {
//        private MainActor mainActor;
//        private Cascadior cascadior;


//        public void RequestSimpleScene()
//        {
//            mainActor.RequestSimpleScene();

//            cascadior.RequestCascadior();
//        }


//        public void RequestCascadior()
//        {
//            cascadior.RequestCascadior();
//        }
//    }

//}
