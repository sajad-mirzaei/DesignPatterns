namespace State.Struct1
{
    class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateB Handle1.");
        }

        public override void Handle2()
        {
            Console.WriteLine($"ConcreteStateB Handle2. StateProperty1: {StateProperty1 + " - " + ++StateProperty1}");
            //_context.TransitionTo(new ConcreteStateA()); //can use
        }
    }
}
