namespace Polymorphism
{
    class ExampleOne
    {
        //Method overloading is an example of Static Polymorphism
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
