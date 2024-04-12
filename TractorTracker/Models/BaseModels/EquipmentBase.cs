using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models.BaseModels
{
    public abstract class EquipmentBase : IBaseInterface
    {
        public string SerialNumber { get; set; }
    }
}
