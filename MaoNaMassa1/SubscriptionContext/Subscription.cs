using MaoNaMassa1.SharedContext;

namespace MaoNaMassa1.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}