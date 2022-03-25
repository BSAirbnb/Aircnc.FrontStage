using Aircnc_0321.Repositories;

namespace Aircnc.FrontStage.Services.Guest
{
    public class SearchRoom
    {
        private readonly DBRepository _DBRepository;
        public SearchRoom(DBRepository dBRepository)
        {
            _DBRepository = dBRepository;
        }
    }
}
