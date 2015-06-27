namespace Fixtures.Azure.SwaggerBatAzureSpecials
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class ApiVersionLocalOperationsExtensions
    {
            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value '2.0'. Possible values
            /// for this parameter include: '2.0'
            /// </param>
            public static void GetMethodLocalValid(this IApiVersionLocalOperations operations, string apiVersion)
            {
                Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetMethodLocalValidAsync(apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value '2.0'. Possible values
            /// for this parameter include: '2.0'
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetMethodLocalValidAsync( this IApiVersionLocalOperations operations, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetMethodLocalValidWithOperationResponseAsync(apiVersion, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// null to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value null, this should
            /// result in no serialized parameter
            /// </param>
            public static void GetMethodLocalNull(this IApiVersionLocalOperations operations, string apiVersion = default(string))
            {
                Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetMethodLocalNullAsync(apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// null to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value null, this should
            /// result in no serialized parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetMethodLocalNullAsync( this IApiVersionLocalOperations operations, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetMethodLocalNullWithOperationResponseAsync(apiVersion, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value '2.0'. Possible values
            /// for this parameter include: '2.0'
            /// </param>
            public static void GetPathLocalValid(this IApiVersionLocalOperations operations, string apiVersion)
            {
                Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetPathLocalValidAsync(apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// This should appear as a method parameter, use value '2.0'. Possible values
            /// for this parameter include: '2.0'
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetPathLocalValidAsync( this IApiVersionLocalOperations operations, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetPathLocalValidWithOperationResponseAsync(apiVersion, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// The api version, which appears in the query, the value is always '2.0'.
            /// Possible values for this parameter include: '2.0'
            /// </param>
            public static void GetSwaggerLocalValid(this IApiVersionLocalOperations operations, string apiVersion)
            {
                Task.Factory.StartNew(s => ((IApiVersionLocalOperations)s).GetSwaggerLocalValidAsync(apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with api-version modeled in the method.  pass in api-version =
            /// '2.0' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='apiVersion'>
            /// The api version, which appears in the query, the value is always '2.0'.
            /// Possible values for this parameter include: '2.0'
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetSwaggerLocalValidAsync( this IApiVersionLocalOperations operations, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetSwaggerLocalValidWithOperationResponseAsync(apiVersion, cancellationToken).ConfigureAwait(false);
            }

    }
}
