#region

using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using LiveKart.Entities;
using Repository.Pattern.Ef6;

#endregion

namespace LiveKart.Web.Test.Fake
{
	public class AssertDbSet : FakeDbSet<Asset>
	{
		public override Asset Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.AssetID == (int) keyValues.FirstOrDefault());
		}

		public override Task<Asset> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<Asset>(() => Find(keyValues));
		}
	}

	public class BeaconDbSet : FakeDbSet<Beacon>
	{
		public override Beacon Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.BeaconID == (string) keyValues.FirstOrDefault());
		}

		public override Task<Beacon> FindAsync(params object[] keyValues)
		{
			return new Task<Beacon>(() => Find(keyValues));
		}

		public override Task<Beacon> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<Beacon>(() => Find(keyValues));
		}
	}

	public class CompanyDbSet : FakeDbSet<Company>
	{
		public override Company Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.CompanyId == (int) keyValues.FirstOrDefault());
		}

		public override Task<Company> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<Company>(() => this.SingleOrDefault(t => t.CompanyId == (int)keyValues.FirstOrDefault()));
		}
	}

	public class BeaconDeploymentDbSet : FakeDbSet<BeaconDeployment>
	{
		public override BeaconDeployment Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.BeaconDeploymentID == (int)keyValues.FirstOrDefault());
		}

		public override Task<BeaconDeployment> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<BeaconDeployment>(() => this.SingleOrDefault(t => t.BeaconDeploymentID == (int)keyValues.FirstOrDefault()));
		}
	}

	public class StandardMessageDbSet : FakeDbSet<StandardMessage>
	{
		public override StandardMessage Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.StandardMessageId == (long)keyValues.FirstOrDefault());
		}

		public override Task<StandardMessage> FindAsync(params object[] keyValues)
		{
			return new Task<StandardMessage>(() => Find(keyValues));
		}

		public override Task<StandardMessage> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<StandardMessage>(() => this.SingleOrDefault(t => t.StandardMessageId == (long)keyValues.FirstOrDefault()));
		}
	}

	public class UserDbSet : FakeDbSet<User>
	{
		public override User Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.LoginID == (long)keyValues.FirstOrDefault());
		}

		public override Task<User> FindAsync(params object[] keyValues)
		{
			return new Task<User>(() => Find(keyValues));
		}

		public override Task<User> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<User>(() => this.SingleOrDefault(t => t.LoginID == (long)keyValues.FirstOrDefault()));
		}
	}


	public class CountryDbSet : FakeDbSet<Country>
	{
		public override Country Find(params object[] keyValues)
		{
			return this.SingleOrDefault(t => t.CountryID == (long)keyValues.FirstOrDefault());
		}

		public override Task<Country> FindAsync(params object[] keyValues)
		{
			return new Task<Country>(() => Find(keyValues));
		}

		public override Task<Country> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
		{
			return new Task<Country>(() => this.SingleOrDefault(t => t.CountryID == (long)keyValues.FirstOrDefault()));
		}
	}
}