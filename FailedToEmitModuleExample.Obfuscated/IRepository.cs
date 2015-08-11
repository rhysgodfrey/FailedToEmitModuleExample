using System;

namespace FailedToEmitModuleExample.Obfuscated
{
    public interface IRepository
    {
        Item Get(Guid contentId);

        Item Get(int threadId, ItemGetOptions options = null);
    }

    public class Item
    {
    }

    public class ItemGetOptions
    {
    }
}
