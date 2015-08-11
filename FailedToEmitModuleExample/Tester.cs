using FailedToEmitModuleExample.Obfuscated;

namespace FailedToEmitModuleExample
{
    public class Tester
    {
        private readonly IRepository _repository;

        public void DoSomething()
        {
            var result = _repository.Get(123);
        }
    }
}
