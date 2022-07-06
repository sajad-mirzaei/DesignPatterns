namespace TemplateMethod.Struct1
{
    public abstract class Abstract1
    {
        protected int Property1 { set; get; } = 0;
        public void TemplateMethod()
        {
            BaseOperation();
            RequiredOperation();
            Hook();
        }
        protected void BaseOperation()
        {
            Console.WriteLine($" - 'AbstractClass' call 'BaseOperation' -> Property1: {Property1}");
        }
        protected abstract void RequiredOperation();
        protected virtual void Hook()
        {
            Console.WriteLine(" - 'AbstractClass' call 'Hook'");
        }
    }
}
