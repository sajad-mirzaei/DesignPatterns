namespace State.Struct1
{
    // Concrete States implement various behaviors, associated with a state of
    // the Context.
    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA Handle1.");
            //_context.TransitionTo(new ConcreteStateB()); //can use
        }

        public override void Handle2()
        {
            Console.WriteLine($"ConcreteStateA Handle2. StateProperty1: {StateProperty1 + " - " + ++StateProperty1}");
        }
    }
}
