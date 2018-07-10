#region

using LiveKart.Entities;
using Repository.Pattern.Ef6;

#endregion

namespace LiveKart.Web.Test.Fake
{
	public class LiveKartFakeContext : FakeDbContext
	{
		public LiveKartFakeContext()
		{
			AddFakeDbSet<Asset, AssertDbSet>();
			AddFakeDbSet<Beacon, BeaconDbSet>();
			AddFakeDbSet<BeaconDeployment, BeaconDeploymentDbSet>();
			AddFakeDbSet<Company, CompanyDbSet>();
			AddFakeDbSet<StandardMessage, StandardMessageDbSet>();
			AddFakeDbSet<User, UserDbSet>();
			AddFakeDbSet<Country, CountryDbSet>();
		}
	}
}
