using TractorTracker.Web.Models.Interfaces;

namespace TractorTracker.Web.Models
{
    public class CoreViewModel<T>
    {
        public T BaseModel { get; set; }
        public int Id {  get; set; }
    }
}
