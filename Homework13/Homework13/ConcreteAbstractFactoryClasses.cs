using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Abstract_Factry
{
    //ArtDeco Class
    class ArtDecoChair : AbstractChair
    {
        public override void Interact(AbstractCoffeeTable coffeeTable)
        {
            Console.WriteLine(this + " Interact with " + coffeeTable);
        }

        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " Interact with " + sofa);
        }
    }

    class ArtDecoSofa : AbstractSofa
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " Interact with " + chair);
        }

        public override void Interact(AbstractCoffeeTable coffeeTable)
        {
            Console.WriteLine(this + " Interact with " + coffeeTable);
        }
    }

    class ArtDecoCoffeeTable : AbstractCoffeeTable
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " Interact with " + chair);
        }

        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " Interact with " + sofa);
        }
    }


    class ArtDecoFactory : AbstractFactory
    {
        public override AbstractChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public override AbstractSofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public override AbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }


    //Victorian Class
    class VictorianChair : AbstractChair
    {
        public override void Interact(AbstractCoffeeTable coffeeTable)
        {
            Console.WriteLine(this + " Interact with " + coffeeTable);
        }

        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " Interact with " + sofa);
        }
    }


    class VictorianSofa : AbstractSofa
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " Interact with " + chair);
        }

        public override void Interact(AbstractCoffeeTable coffeeTable)
        {
            Console.WriteLine(this + " Interact with " + coffeeTable);
        }
    }

    class VictorianCoffeeTable : AbstractCoffeeTable
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " Interact with " + chair);
        }

        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " Interact with " + sofa);
        }
    }

    class VictorianFactory : AbstractFactory
    {
        public override AbstractChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public override AbstractSofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public override AbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }



    //Modern Class
    class ModernChair : AbstractChair
    {
        public override void Interact(AbstractCoffeeTable coffeeTable)
        {
            Console.WriteLine(this + " Interact with " + coffeeTable);
        }

        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " Interact with " + sofa);
        }
    }

    class ModernSofa : AbstractSofa
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " Interact with " + chair);
        }

        public override void Interact(AbstractCoffeeTable coffeeTable)
        {
            Console.WriteLine(this + " Interact with " + coffeeTable);
        }
    }

    class ModernCoffeeTable : AbstractCoffeeTable
    {
        public override void Interact(AbstractChair chair)
        {
            Console.WriteLine(this + " Interact with " + chair);
        }

        public override void Interact(AbstractSofa sofa)
        {
            Console.WriteLine(this + " Interact with " + sofa);
        }
    }

    class ModernFactory : AbstractFactory
    {
        public override AbstractChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public override AbstractSofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public override AbstractCoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }


    //Client
    public class Client
    {
        private AbstractChair chair;
        private AbstractSofa sofa;
        private AbstractCoffeeTable coffeeTable;

        public Client(AbstractFactory factory)
        {
            chair = factory.CreateChair();
            sofa = factory.CreateSofa();
            coffeeTable = factory.CreateCoffeeTable();
        }

        public void Run()
        {
            chair.Interact(sofa);
            chair.Interact(coffeeTable);
        }

        public void Run1()
        {
            sofa.Interact(coffeeTable);
            coffeeTable.Interact(chair);
        }

        public void Run2()
        {
            chair.Interact(sofa);
            sofa.Interact(coffeeTable);
            coffeeTable.Interact(chair);
        }
    }
}
