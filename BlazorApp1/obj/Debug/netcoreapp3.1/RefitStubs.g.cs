﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using BlazorApp1.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace BlazorApp1.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace BlazorApp1.Data
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Refit;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIRemoteService : IRemoteService
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIRemoteService(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<Tarea>> IRemoteService.GetAllTarea()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllTarea", new Type[] {  });
            return (Task<List<Tarea>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.GetTarea(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetTarea", new Type[] { typeof(int) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.GuardarTarea(Tarea valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarTarea", new Type[] { typeof(Tarea) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Tarea> IRemoteService.BorrarTarea(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("BorrarTarea", new Type[] { typeof(int) });
            return (Task<Tarea>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Usuario>> IRemoteService.GetAllUsuario()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllUsuario", new Type[] {  });
            return (Task<List<Usuario>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.GetUsuario(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUsuario", new Type[] { typeof(int) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.GuardarUsuario(Usuario valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarUsuario", new Type[] { typeof(Usuario) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Usuario> IRemoteService.BorrarUsuario(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("BorrarUsuario", new Type[] { typeof(int) });
            return (Task<Usuario>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Detalle>> IRemoteService.GetAllDetalle()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllDetalle", new Type[] {  });
            return (Task<List<Detalle>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.GetDetalle(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetDetalle", new Type[] { typeof(int) });
            return (Task<Detalle>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.GuardarDetalle(Detalle valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarDetalle", new Type[] { typeof(Detalle) });
            return (Task<Detalle>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Detalle> IRemoteService.BorrarDetalle(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("BorrarDetalle", new Type[] { typeof(int) });
            return (Task<Detalle>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Recurso>> IRemoteService.GetAllRecurso()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAllRecurso", new Type[] {  });
            return (Task<List<Recurso>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.GetRecurso(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetRecurso", new Type[] { typeof(int) });
            return (Task<Recurso>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.GuardarRecurso(Recurso valor)
        {
            var arguments = new object[] { valor };
            var func = requestBuilder.BuildRestResultFuncForMethod("GuardarRecurso", new Type[] { typeof(Recurso) });
            return (Task<Recurso>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Recurso> IRemoteService.BorrarRecurso(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("BorrarRecurso", new Type[] { typeof(int) });
            return (Task<Recurso>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
