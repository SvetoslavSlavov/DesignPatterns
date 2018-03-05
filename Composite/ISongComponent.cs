using System;

namespace Composite
{
    public interface ISongComponent
    {
        void Add(ISongComponent component);
        void Remove(ISongComponent component);
        void DisplayInfo();
    }
}
