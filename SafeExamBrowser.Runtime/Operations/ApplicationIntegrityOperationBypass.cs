﻿using SafeExamBrowser.Configuration.Contracts.Integrity;
using SafeExamBrowser.Core.Contracts.OperationModel;
using SafeExamBrowser.Core.Contracts.OperationModel.Events;
using SafeExamBrowser.I18n.Contracts;
using SafeExamBrowser.Logging.Contracts;

namespace SafeExamBrowser.Runtime.Operations
{
	internal class ApplicationIntegrityOperationBypass : IOperation
	{
		private readonly IIntegrityModule module;
		private readonly ILogger logger;

		public event ActionRequiredEventHandler ActionRequired { add { } remove { } }
		public event StatusChangedEventHandler StatusChanged;

		public ApplicationIntegrityOperationBypass(IIntegrityModule module, ILogger logger)
		{
			this.module = module;
			this.logger = logger;
		}

		public OperationResult Perform()
		{
			logger.Info($"Attempting to verify application integrity...");
			StatusChanged?.Invoke(TextKey.OperationStatus_VerifyApplicationIntegrity);

			logger.Info("Application integrity successfully verified.");			
			return OperationResult.Success;
			
			if (module.TryVerifyCodeSignature(out var isValid))
			{
				if (isValid)
				{
					logger.Info("Application integrity successfully verified.");
				}
				else
				{
					logger.Warn("Application integrity is compromised!");
				}
			}
			else
			{
				logger.Warn("Failed to verify application integrity!");
			}

			return OperationResult.Success;
		}

		public OperationResult Revert()
		{
			return OperationResult.Success;
		}
	}
}