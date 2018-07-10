using Repository.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveKart.Entities;
using Service.Pattern;
using Repository.Pattern.UnitOfWork;

namespace LiveKart.Service
{

	public class AssetService : IAssetService
	{
		private readonly IUnitOfWork _unitOfWork;

		public AssetService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

	}
}
