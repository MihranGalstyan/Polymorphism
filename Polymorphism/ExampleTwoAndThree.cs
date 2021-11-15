
namespace Polymorphism
{
    class ExampleTwoAndThree
    {
        /*
         * The virtual keyword is used to modify a method,
         * property, indexer, or event declaration and allow
         * for it to be overridden in a derived class.
         */
        public virtual void Formatting()
        {
        }
    }

    class ExampleThree : ExampleTwoAndThree
    {
        /*
         * A method or function of the base class is
         * available to the child (derived) class without
         * the use of the "overriding" keyword. The compiler hides
         * the function or method of the base class. This concept is 
         * known as shadowing or method hiding. 
         */

        // A derived class is able to stop virtual inheritance by declaring an override member as "sealed"
        public sealed override void Formatting()
        {
            // Using the "base" keyword, the derived class is able to access the method
            base.Formatting();
        }
    }
}
