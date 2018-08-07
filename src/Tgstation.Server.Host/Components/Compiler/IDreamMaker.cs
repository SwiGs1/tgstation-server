﻿using System.Threading;
using System.Threading.Tasks;
using Tgstation.Server.Api.Models;
using Tgstation.Server.Host.Components.Repository;

namespace Tgstation.Server.Host.Components.Compiler
{
	/// <summary>
	/// For managing the compiler
	/// </summary>
	public interface IDreamMaker
	{
		/// <summary>
		/// The <see cref="Api.Models.CompilerStatus"/> of <see cref="IDreamMaker"/>
		/// </summary>
		Api.Models.CompilerStatus Status { get; }

		/// <summary>
		/// Starts a compile
		/// </summary>
		/// <param name="projectName">The optional name of the .dme to compile without the extension if not pre</param>
		/// <param name="securityLevel">The <see cref="DreamDaemonSecurity"/> level allowed for API validation</param>
		/// <param name="apiValidateTimeout">The time in seconds to wait while validating the API</param>
		/// <param name="repository">The <see cref="IRepository"/> to copy from</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task{TResult}"/> resulting in the partially populated <see cref="CompileJob"/> for the operation. In particular, note the <see cref="CompileJob.RevisionInformation"/> field will only have it's <see cref="Api.Models.Internal.RevisionInformation.CommitSha"/> field populated</returns>
		Task<Models.CompileJob> Compile(string projectName, DreamDaemonSecurity securityLevel, uint apiValidateTimeout, IRepository repository, CancellationToken cancellationToken);
	}
}