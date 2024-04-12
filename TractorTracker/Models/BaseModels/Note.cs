using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models.BaseModels
{
    public class Note : IBaseInterface
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
