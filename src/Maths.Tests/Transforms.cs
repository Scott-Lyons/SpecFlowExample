using System.Collections.Generic;
using Maths.Tests.Entities;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Maths.Tests
{
    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation]
        public IEnumerable<Number> TransformTableToNumberEntities(Table table)
            => table.CreateSet<Number>();
    }
}
