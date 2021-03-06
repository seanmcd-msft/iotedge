// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Routing.Core.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Azure.Devices.Edge.Util;
    using Microsoft.Azure.Devices.Routing.Core.Checkpointers;

    public class AsyncEndpointExecutorFactory : IEndpointExecutorFactory
    {
        readonly EndpointExecutorConfig config;
        readonly AsyncEndpointExecutorOptions options;

        public AsyncEndpointExecutorFactory(EndpointExecutorConfig config, AsyncEndpointExecutorOptions options)
        {
            this.config = Preconditions.CheckNotNull(config);
            this.options = Preconditions.CheckNotNull(options);
        }

        public Task<IEndpointExecutor> CreateAsync(Endpoint endpoint, IList<uint> _)
        {
            IEndpointExecutor executor = new AsyncEndpointExecutor(endpoint, NullCheckpointer.Instance, this.config, this.options);
            return Task.FromResult(executor);
        }

        public Task<IEndpointExecutor> CreateAsync(Endpoint endpoint, IList<uint> _, ICheckpointer checkpointer)
        {
            IEndpointExecutor executor = new AsyncEndpointExecutor(endpoint, checkpointer, this.config, this.options);
            return Task.FromResult(executor);
        }

        public Task<IEndpointExecutor> CreateAsync(Endpoint endpoint, IList<uint> _, ICheckpointer checkpointer, EndpointExecutorConfig endpointExecutorConfig)
        {
            IEndpointExecutor executor = new AsyncEndpointExecutor(endpoint, checkpointer, endpointExecutorConfig, this.options);
            return Task.FromResult(executor);
        }
    }
}
