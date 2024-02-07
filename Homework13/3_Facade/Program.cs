using System;

namespace _3_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperationHTML();
            Console.WriteLine();
            facade.OperationPDF();
        }
    }

    class Facade
    {
        Header header = new Header();
        Body body = new Body();
        Footer footer = new Footer();

        public void OperationHTML()
        {
            header.HeaderOperationHTML();
            body.BodyOperationHTML();
            footer.FooterOperationHTML();
        }

        public void OperationPDF()
        {
            header.HeaderOperationPDF();
            body.BodyOperationPDF();
            footer.FooterOperationPDF();
        }
    }


    //Header
    class Header
    {
        public void HeaderOperationHTML()
        {
            Console.WriteLine("<header> My Header </header>");
        }

        public void HeaderOperationPDF()
        {
            Console.WriteLine("I'm using Facade Pattern");
        }
    }

    //Body
    class Body
    {
        public void BodyOperationHTML()
        {
            Console.WriteLine("<body>");
            Console.WriteLine("Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add.");
            Console.WriteLine("</body>");
        }

        public void BodyOperationPDF()
        {
            Console.WriteLine("Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document. To make your document look professionally produced, Word provides ");
        }
    }

    //Footer
    class Footer
    {
        public void FooterOperationHTML()
        {
            Console.WriteLine("<footer> My Footer </footer>");
        }

        public void FooterOperationPDF()
        {
            Console.WriteLine("Page 1");
        }
    }

}
