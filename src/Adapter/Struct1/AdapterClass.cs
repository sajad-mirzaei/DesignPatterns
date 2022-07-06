namespace Adapter.Struct1
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class AdapterClass : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterClass(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}