namespace SandBox
{
    class Animal { }

    class Cat : Animal { }

    interface IZoo <in T> where T : Animal {
        //T Get();
        void Push(T animal);
    }

    class CatZoo : IZoo<Cat> {
        public Cat Get()
        {
            return new Cat();
        }
        public void Push(Cat cat) { }
    }

    class Zoo : IZoo<Animal>
    {
        public Animal Get()
        {
            return new Animal();
        }
        public void Push(Animal cat) { }
    }

    class MyClass {
        static void Main(string[] args)
        {
            IZoo<Animal> animalZoo = new Zoo();
            IZoo<Cat> catZoo = new CatZoo();
            //animalZoo = catZoo;
            catZoo = animalZoo;
        }
    }
}

