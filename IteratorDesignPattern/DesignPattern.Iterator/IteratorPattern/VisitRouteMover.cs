namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> VisitRoutes = new List<VisitRoute>();

        public void AddVisitRoute(VisitRoute visitRoute)
        {
            VisitRoutes.Add(visitRoute);
        }

        public int VisitRouteCount { get => VisitRoutes.Count; }

        public IIterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
