using NUnit.Framework;
using ReneWiersma.Preconditions;
using System;

namespace PreconditionsTests
{
    public class PreconditionTests
    {
        [Test]
        public void PreconditionTrue()
        { 
            Assert.That(() => Precondition.Requires(true), Throws.Nothing);
        }

        [Test]
        public void PreconditionFalse()
        {
            Assert.That(() => Precondition.Requires(false), Throws.ArgumentException.With.Message.EqualTo("Precondition failed"));
        }

        [Test]
        public void PreconditionFalseWithCustomExceptionMessage()
        {
            Assert.That(() => Precondition.Requires(false, "A custom message"), Throws.ArgumentException.With.Message.EqualTo("A custom message"));
        }

        [Test]
        public void PreconditionFalseWithAnotherExceptionType()
        {
            Assert.That
            (
                () => Precondition.Requires(false, () => new InvalidOperationException("A custom message")), 
                Throws.InvalidOperationException.With.Message.EqualTo("A custom message")
            );
        }
    }
}
