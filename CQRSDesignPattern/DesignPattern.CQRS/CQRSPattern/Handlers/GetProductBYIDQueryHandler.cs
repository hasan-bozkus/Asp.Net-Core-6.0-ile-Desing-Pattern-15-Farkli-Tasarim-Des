﻿using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductBYIDQueryHandler
    {
        private readonly Context _context;

        public GetProductBYIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                ProductID = values.ProductID
            };
        }
    }
}
