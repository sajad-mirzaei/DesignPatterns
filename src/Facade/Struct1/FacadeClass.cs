namespace Facade.Struct1
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class FacadeClass
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public FacadeClass(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += _subsystem1.operation1();
            result += _subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += _subsystem1.operationN();
            result += _subsystem2.operationZ();
            return result;
        }
    }
}