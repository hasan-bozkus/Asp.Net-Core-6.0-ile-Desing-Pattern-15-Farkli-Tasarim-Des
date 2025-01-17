﻿namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private readonly VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }

        private int currentIndex = 0;

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex < _visitRouteMover.VisitRouteCount)
            {
                CurrentItem = _visitRouteMover.VisitRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
