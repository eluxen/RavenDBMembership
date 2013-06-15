using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Raven.Client;
using Raven.Client.Embedded;

namespace RavenDBMembership.Tests
{
	public abstract class InMemoryStoreTestcase
	{
        protected IDocumentStore NewInMemoryStore()
		{
            IDocumentStore documentStore = new Raven.Client.Embedded.EmbeddableDocumentStore()
            {
                RunInMemory = true,
            };
			documentStore.Initialize();
			return documentStore;
		}
	}
}
