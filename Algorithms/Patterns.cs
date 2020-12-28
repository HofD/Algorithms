namespace Patterns
{
    #region Factory
    public interface IPhone
    {
        void Ring();
    }

    public class PhoneA : IPhone
    {
        public void Ring()
        {
            throw new System.NotImplementedException();
        }
    }

    public class PhoneB : IPhone
    {
        public void Ring()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IPhoneCreator
    {
        IPhone CreatePhone();
    }

    public class PhoneCreatorA : IPhoneCreator
    {
        public IPhone CreatePhone()
        {
            return new PhoneA();
        }
    }

    public class PhoneCreatorB : IPhoneCreator
    {
        public IPhone CreatePhone()
        {
            return new PhoneB();
        }
    }
    #endregion

    #region Abstract Factory
    public interface IWorkerA
    {
        void Do();
    }

    public interface IWorkerB
    {
        void Do();
    }

    public interface IFactory
    {
        IWorkerA CreateWorkerA();

         IWorkerB CreateWorkerB();
    }

    public class WorkerA1 : IWorkerA
    {
        public void Do()
        {
            throw new System.NotImplementedException();
        }
    }

    public class WorkerA2 : IWorkerA
    {
        public void Do()
        {
            throw new System.NotImplementedException();
        }
    }

    public class WorkerB1 : IWorkerB
    {
        public void Do()
        {
            throw new System.NotImplementedException();
        }
    }

    public class WorkerB2 : IWorkerB
    {
        public void Do()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Factory1 : IFactory
    {
        public IWorkerA CreateWorkerA()
        {
            return new WorkerA1();
        }

        public IWorkerB CreateWorkerB()
        {
            return new WorkerB1();
        }
    }

    public class Factory2 : IFactory
    {
        public IWorkerA CreateWorkerA()
        {
            return new WorkerA2();
        }

        public IWorkerB CreateWorkerB()
        {
            return new WorkerB2();
        }
    }

    public class FactoryRunner
    {
        private IWorkerA workerA;
        private IWorkerB workerB;

        public FactoryRunner(IFactory factory)
        {
            workerA = factory.CreateWorkerA();
            workerB = factory.CreateWorkerB();
        }

        public void Run()
        {
            workerA.Do();
            workerB.Do();
        }
    }


    #endregion
}